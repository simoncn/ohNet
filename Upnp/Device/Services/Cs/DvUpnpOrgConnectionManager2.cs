using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp;

namespace Zapp.Device.Providers
{
    public class DvProviderUpnpOrgConnectionManager2 : DvProvider, IDisposable
    {
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern uint DvProviderUpnpOrgConnectionManager2Create(uint aDeviceHandle);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern void DvProviderUpnpOrgConnectionManager2Destroy(uint aHandle);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern unsafe int DvProviderUpnpOrgConnectionManager2SetPropertySourceProtocolInfo(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern unsafe void DvProviderUpnpOrgConnectionManager2GetPropertySourceProtocolInfo(uint aHandle, char** aValue);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern unsafe int DvProviderUpnpOrgConnectionManager2SetPropertySinkProtocolInfo(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern unsafe void DvProviderUpnpOrgConnectionManager2GetPropertySinkProtocolInfo(uint aHandle, char** aValue);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern unsafe int DvProviderUpnpOrgConnectionManager2SetPropertyCurrentConnectionIDs(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern unsafe void DvProviderUpnpOrgConnectionManager2GetPropertyCurrentConnectionIDs(uint aHandle, char** aValue);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern void DvProviderUpnpOrgConnectionManager2EnableActionGetProtocolInfo(uint aHandle, CallbackGetProtocolInfo aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern void DvProviderUpnpOrgConnectionManager2EnableActionPrepareForConnection(uint aHandle, CallbackPrepareForConnection aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern void DvProviderUpnpOrgConnectionManager2EnableActionConnectionComplete(uint aHandle, CallbackConnectionComplete aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern void DvProviderUpnpOrgConnectionManager2EnableActionGetCurrentConnectionIDs(uint aHandle, CallbackGetCurrentConnectionIDs aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgConnectionManager2")]
        static extern void DvProviderUpnpOrgConnectionManager2EnableActionGetCurrentConnectionInfo(uint aHandle, CallbackGetCurrentConnectionInfo aCallback, IntPtr aPtr);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(void* aPtr);

        private unsafe delegate int CallbackGetProtocolInfo(IntPtr aPtr, uint aVersion, char** aSource, char** aSink);
        private unsafe delegate int CallbackPrepareForConnection(IntPtr aPtr, uint aVersion, char* aRemoteProtocolInfo, char* aPeerConnectionManager, int aPeerConnectionID, char* aDirection, int* aConnectionID, int* aAVTransportID, int* aRcsID);
        private unsafe delegate int CallbackConnectionComplete(IntPtr aPtr, uint aVersion, int aConnectionID);
        private unsafe delegate int CallbackGetCurrentConnectionIDs(IntPtr aPtr, uint aVersion, char** aConnectionIDs);
        private unsafe delegate int CallbackGetCurrentConnectionInfo(IntPtr aPtr, uint aVersion, int aConnectionID, int* aRcsID, int* aAVTransportID, char** aProtocolInfo, char** aPeerConnectionManager, int* aPeerConnectionID, char** aDirection, char** aStatus);

        private GCHandle iGch;
        private CallbackGetProtocolInfo iCallbackGetProtocolInfo;
        private CallbackPrepareForConnection iCallbackPrepareForConnection;
        private CallbackConnectionComplete iCallbackConnectionComplete;
        private CallbackGetCurrentConnectionIDs iCallbackGetCurrentConnectionIDs;
        private CallbackGetCurrentConnectionInfo iCallbackGetCurrentConnectionInfo;

        public DvProviderUpnpOrgConnectionManager2(DvDevice aDevice)
        {
            iHandle = DvProviderUpnpOrgConnectionManager2Create(aDevice.Handle()); 
            iGch = GCHandle.Alloc(this);
        }

        public unsafe bool SetPropertySourceProtocolInfo(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderUpnpOrgConnectionManager2SetPropertySourceProtocolInfo(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertySourceProtocolInfo(out string aValue)
        {
            char* value;
            DvProviderUpnpOrgConnectionManager2GetPropertySourceProtocolInfo(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertySinkProtocolInfo(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderUpnpOrgConnectionManager2SetPropertySinkProtocolInfo(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertySinkProtocolInfo(out string aValue)
        {
            char* value;
            DvProviderUpnpOrgConnectionManager2GetPropertySinkProtocolInfo(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyCurrentConnectionIDs(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderUpnpOrgConnectionManager2SetPropertyCurrentConnectionIDs(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyCurrentConnectionIDs(out string aValue)
        {
            char* value;
            DvProviderUpnpOrgConnectionManager2GetPropertyCurrentConnectionIDs(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        protected unsafe void EnableActionGetProtocolInfo()
        {
            iCallbackGetProtocolInfo = new CallbackGetProtocolInfo(DoGetProtocolInfo);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgConnectionManager2EnableActionGetProtocolInfo(iHandle, iCallbackGetProtocolInfo, ptr);
        }

        protected unsafe void EnableActionPrepareForConnection()
        {
            iCallbackPrepareForConnection = new CallbackPrepareForConnection(DoPrepareForConnection);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgConnectionManager2EnableActionPrepareForConnection(iHandle, iCallbackPrepareForConnection, ptr);
        }

        protected unsafe void EnableActionConnectionComplete()
        {
            iCallbackConnectionComplete = new CallbackConnectionComplete(DoConnectionComplete);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgConnectionManager2EnableActionConnectionComplete(iHandle, iCallbackConnectionComplete, ptr);
        }

        protected unsafe void EnableActionGetCurrentConnectionIDs()
        {
            iCallbackGetCurrentConnectionIDs = new CallbackGetCurrentConnectionIDs(DoGetCurrentConnectionIDs);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgConnectionManager2EnableActionGetCurrentConnectionIDs(iHandle, iCallbackGetCurrentConnectionIDs, ptr);
        }

        protected unsafe void EnableActionGetCurrentConnectionInfo()
        {
            iCallbackGetCurrentConnectionInfo = new CallbackGetCurrentConnectionInfo(DoGetCurrentConnectionInfo);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgConnectionManager2EnableActionGetCurrentConnectionInfo(iHandle, iCallbackGetCurrentConnectionInfo, ptr);
        }

        protected virtual void GetProtocolInfo(uint aVersion, out string aSource, out string aSink)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void PrepareForConnection(uint aVersion, string aRemoteProtocolInfo, string aPeerConnectionManager, int aPeerConnectionID, string aDirection, out int aConnectionID, out int aAVTransportID, out int aRcsID)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void ConnectionComplete(uint aVersion, int aConnectionID)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void GetCurrentConnectionIDs(uint aVersion, out string aConnectionIDs)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void GetCurrentConnectionInfo(uint aVersion, int aConnectionID, out int aRcsID, out int aAVTransportID, out string aProtocolInfo, out string aPeerConnectionManager, out int aPeerConnectionID, out string aDirection, out string aStatus)
        {
            throw (new ActionDisabledError());
        }

        private static unsafe int DoGetProtocolInfo(IntPtr aPtr, uint aVersion, char** aSource, char** aSink)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgConnectionManager2 self = (DvProviderUpnpOrgConnectionManager2)gch.Target;
            string source;
            string sink;
            self.GetProtocolInfo(aVersion, out source, out sink);
            *aSource = (char*)Marshal.StringToHGlobalAnsi(source).ToPointer();
            *aSink = (char*)Marshal.StringToHGlobalAnsi(sink).ToPointer();
            return 0;
        }

        private static unsafe int DoPrepareForConnection(IntPtr aPtr, uint aVersion, char* aRemoteProtocolInfo, char* aPeerConnectionManager, int aPeerConnectionID, char* aDirection, int* aConnectionID, int* aAVTransportID, int* aRcsID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgConnectionManager2 self = (DvProviderUpnpOrgConnectionManager2)gch.Target;
            string remoteProtocolInfo = Marshal.PtrToStringAnsi((IntPtr)aRemoteProtocolInfo);
            string peerConnectionManager = Marshal.PtrToStringAnsi((IntPtr)aPeerConnectionManager);
            string direction = Marshal.PtrToStringAnsi((IntPtr)aDirection);
            int connectionID;
            int aVTransportID;
            int rcsID;
            self.PrepareForConnection(aVersion, remoteProtocolInfo, peerConnectionManager, aPeerConnectionID, direction, out connectionID, out aVTransportID, out rcsID);
            *aConnectionID = connectionID;
            *aAVTransportID = aVTransportID;
            *aRcsID = rcsID;
            return 0;
        }

        private static unsafe int DoConnectionComplete(IntPtr aPtr, uint aVersion, int aConnectionID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgConnectionManager2 self = (DvProviderUpnpOrgConnectionManager2)gch.Target;
            self.ConnectionComplete(aVersion, aConnectionID);
            return 0;
        }

        private static unsafe int DoGetCurrentConnectionIDs(IntPtr aPtr, uint aVersion, char** aConnectionIDs)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgConnectionManager2 self = (DvProviderUpnpOrgConnectionManager2)gch.Target;
            string connectionIDs;
            self.GetCurrentConnectionIDs(aVersion, out connectionIDs);
            *aConnectionIDs = (char*)Marshal.StringToHGlobalAnsi(connectionIDs).ToPointer();
            return 0;
        }

        private static unsafe int DoGetCurrentConnectionInfo(IntPtr aPtr, uint aVersion, int aConnectionID, int* aRcsID, int* aAVTransportID, char** aProtocolInfo, char** aPeerConnectionManager, int* aPeerConnectionID, char** aDirection, char** aStatus)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgConnectionManager2 self = (DvProviderUpnpOrgConnectionManager2)gch.Target;
            int rcsID;
            int aVTransportID;
            string protocolInfo;
            string peerConnectionManager;
            int peerConnectionID;
            string direction;
            string status;
            self.GetCurrentConnectionInfo(aVersion, aConnectionID, out rcsID, out aVTransportID, out protocolInfo, out peerConnectionManager, out peerConnectionID, out direction, out status);
            *aRcsID = rcsID;
            *aAVTransportID = aVTransportID;
            *aProtocolInfo = (char*)Marshal.StringToHGlobalAnsi(protocolInfo).ToPointer();
            *aPeerConnectionManager = (char*)Marshal.StringToHGlobalAnsi(peerConnectionManager).ToPointer();
            *aPeerConnectionID = peerConnectionID;
            *aDirection = (char*)Marshal.StringToHGlobalAnsi(direction).ToPointer();
            *aStatus = (char*)Marshal.StringToHGlobalAnsi(status).ToPointer();
            return 0;
        }


        public void Dispose()
        {
            DoDispose();
            GC.SuppressFinalize(this);
        }

        ~DvProviderUpnpOrgConnectionManager2()
        {
            DoDispose();
        }

        private void DoDispose()
        {
            uint handle;
            lock (this)
            {
                if (iHandle == 0)
                {
                    return;
                }
                handle = iHandle;
                iHandle = 0;
            }
            DvProviderUpnpOrgConnectionManager2Destroy(handle);
            if (iGch.IsAllocated)
            {
                iGch.Free();
            }
        }
    }
}

