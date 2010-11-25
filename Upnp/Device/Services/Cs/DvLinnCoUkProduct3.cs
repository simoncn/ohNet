using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp;

namespace Zapp.Device.Providers
{
    public class DvProviderLinnCoUkProduct3 : DvProvider, IDisposable
    {
        [DllImport("DvLinnCoUkProduct3")]
        static extern uint DvProviderLinnCoUkProduct3Create(uint aDeviceHandle);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3Destroy(uint aHandle);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductType(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductType(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductModel(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductModel(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductName(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductName(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductRoom(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductRoom(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductStandby(uint aHandle, int aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductStandby(uint aHandle, int* aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductSourceIndex(uint aHandle, uint aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductSourceIndex(uint aHandle, uint* aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductSourceCount(uint aHandle, uint aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductSourceCount(uint aHandle, uint* aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductSourceXml(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductSourceXml(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyStartupSourceIndex(uint aHandle, uint aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyStartupSourceIndex(uint aHandle, uint* aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyStartupSourceEnabled(uint aHandle, int aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyStartupSourceEnabled(uint aHandle, int* aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductAnySourceName(uint aHandle, uint aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductAnySourceName(uint aHandle, uint* aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductAnySourceVisible(uint aHandle, uint aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductAnySourceVisible(uint aHandle, uint* aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe int DvProviderLinnCoUkProduct3SetPropertyProductAnySourceType(uint aHandle, uint aValue, uint* aChanged);
        [DllImport("DvLinnCoUkProduct3")]
        static extern unsafe void DvProviderLinnCoUkProduct3GetPropertyProductAnySourceType(uint aHandle, uint* aValue);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionType(uint aHandle, CallbackType aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionModel(uint aHandle, CallbackModel aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionName(uint aHandle, CallbackName aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetName(uint aHandle, CallbackSetName aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionRoom(uint aHandle, CallbackRoom aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetRoom(uint aHandle, CallbackSetRoom aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionStandby(uint aHandle, CallbackStandby aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetStandby(uint aHandle, CallbackSetStandby aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSourceCount(uint aHandle, CallbackSourceCount aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSourceXml(uint aHandle, CallbackSourceXml aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSourceIndex(uint aHandle, CallbackSourceIndex aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetSourceIndex(uint aHandle, CallbackSetSourceIndex aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetSourceIndexByName(uint aHandle, CallbackSetSourceIndexByName aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetStartupSourceIndexByName(uint aHandle, CallbackSetStartupSourceIndexByName aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionStartupSourceIndex(uint aHandle, CallbackStartupSourceIndex aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetStartupSourceIndex(uint aHandle, CallbackSetStartupSourceIndex aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionStartupSourceEnabled(uint aHandle, CallbackStartupSourceEnabled aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetStartupSourceEnabled(uint aHandle, CallbackSetStartupSourceEnabled aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSourceSystemName(uint aHandle, CallbackSourceSystemName aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSourceName(uint aHandle, CallbackSourceName aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetSourceName(uint aHandle, CallbackSetSourceName aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSourceType(uint aHandle, CallbackSourceType aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSourceVisible(uint aHandle, CallbackSourceVisible aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkProduct3")]
        static extern void DvProviderLinnCoUkProduct3EnableActionSetSourceVisible(uint aHandle, CallbackSetSourceVisible aCallback, IntPtr aPtr);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(void* aPtr);

        private unsafe delegate int CallbackType(IntPtr aPtr, uint aVersion, char** aaType);
        private unsafe delegate int CallbackModel(IntPtr aPtr, uint aVersion, char** aaModel);
        private unsafe delegate int CallbackName(IntPtr aPtr, uint aVersion, char** aaName);
        private unsafe delegate int CallbackSetName(IntPtr aPtr, uint aVersion, char* aaName);
        private unsafe delegate int CallbackRoom(IntPtr aPtr, uint aVersion, char** aaRoom);
        private unsafe delegate int CallbackSetRoom(IntPtr aPtr, uint aVersion, char* aaRoom);
        private unsafe delegate int CallbackStandby(IntPtr aPtr, uint aVersion, int* aaStandby);
        private unsafe delegate int CallbackSetStandby(IntPtr aPtr, uint aVersion, int aaStandby);
        private unsafe delegate int CallbackSourceCount(IntPtr aPtr, uint aVersion, uint* aaSourceCount);
        private unsafe delegate int CallbackSourceXml(IntPtr aPtr, uint aVersion, char** aaSourceXml);
        private unsafe delegate int CallbackSourceIndex(IntPtr aPtr, uint aVersion, uint* aaSourceIndex);
        private unsafe delegate int CallbackSetSourceIndex(IntPtr aPtr, uint aVersion, uint aaSourceIndex);
        private unsafe delegate int CallbackSetSourceIndexByName(IntPtr aPtr, uint aVersion, char* aaSourceName);
        private unsafe delegate int CallbackSetStartupSourceIndexByName(IntPtr aPtr, uint aVersion, char* aaSourceName);
        private unsafe delegate int CallbackStartupSourceIndex(IntPtr aPtr, uint aVersion, uint* aaSourceIndex);
        private unsafe delegate int CallbackSetStartupSourceIndex(IntPtr aPtr, uint aVersion, uint aaSourceIndex);
        private unsafe delegate int CallbackStartupSourceEnabled(IntPtr aPtr, uint aVersion, int* aaStartupSourceEnabled);
        private unsafe delegate int CallbackSetStartupSourceEnabled(IntPtr aPtr, uint aVersion, int aaStartupSourceEnabled);
        private unsafe delegate int CallbackSourceSystemName(IntPtr aPtr, uint aVersion, uint aaSourceIndex, char** aaSourceName);
        private unsafe delegate int CallbackSourceName(IntPtr aPtr, uint aVersion, uint aaSourceIndex, char** aaSourceName);
        private unsafe delegate int CallbackSetSourceName(IntPtr aPtr, uint aVersion, uint aaSourceIndex, char* aaSourceName);
        private unsafe delegate int CallbackSourceType(IntPtr aPtr, uint aVersion, uint aaSourceIndex, char** aaSourceType);
        private unsafe delegate int CallbackSourceVisible(IntPtr aPtr, uint aVersion, uint aaSourceIndex, int* aaSourceVisible);
        private unsafe delegate int CallbackSetSourceVisible(IntPtr aPtr, uint aVersion, uint aaSourceIndex, int aaSourceVisible);

        private GCHandle iGch;
        private CallbackType iCallbackType;
        private CallbackModel iCallbackModel;
        private CallbackName iCallbackName;
        private CallbackSetName iCallbackSetName;
        private CallbackRoom iCallbackRoom;
        private CallbackSetRoom iCallbackSetRoom;
        private CallbackStandby iCallbackStandby;
        private CallbackSetStandby iCallbackSetStandby;
        private CallbackSourceCount iCallbackSourceCount;
        private CallbackSourceXml iCallbackSourceXml;
        private CallbackSourceIndex iCallbackSourceIndex;
        private CallbackSetSourceIndex iCallbackSetSourceIndex;
        private CallbackSetSourceIndexByName iCallbackSetSourceIndexByName;
        private CallbackSetStartupSourceIndexByName iCallbackSetStartupSourceIndexByName;
        private CallbackStartupSourceIndex iCallbackStartupSourceIndex;
        private CallbackSetStartupSourceIndex iCallbackSetStartupSourceIndex;
        private CallbackStartupSourceEnabled iCallbackStartupSourceEnabled;
        private CallbackSetStartupSourceEnabled iCallbackSetStartupSourceEnabled;
        private CallbackSourceSystemName iCallbackSourceSystemName;
        private CallbackSourceName iCallbackSourceName;
        private CallbackSetSourceName iCallbackSetSourceName;
        private CallbackSourceType iCallbackSourceType;
        private CallbackSourceVisible iCallbackSourceVisible;
        private CallbackSetSourceVisible iCallbackSetSourceVisible;

        public DvProviderLinnCoUkProduct3(DvDevice aDevice)
        {
            iHandle = DvProviderLinnCoUkProduct3Create(aDevice.Handle()); 
            iGch = GCHandle.Alloc(this);
        }

        public unsafe bool SetPropertyProductType(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkProduct3SetPropertyProductType(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductType(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkProduct3GetPropertyProductType(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyProductModel(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkProduct3SetPropertyProductModel(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductModel(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkProduct3GetPropertyProductModel(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyProductName(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkProduct3SetPropertyProductName(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductName(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkProduct3GetPropertyProductName(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyProductRoom(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkProduct3SetPropertyProductRoom(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductRoom(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkProduct3GetPropertyProductRoom(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyProductStandby(bool aValue)
        {
        uint changed;
            int value = (aValue ? 1 : 0);
            if (0 != DvProviderLinnCoUkProduct3SetPropertyProductStandby(iHandle, value, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductStandby(out bool aValue)
        {
            int value;
            DvProviderLinnCoUkProduct3GetPropertyProductStandby(iHandle, &value);
            aValue = (value != 0);
        }

        public unsafe bool SetPropertyProductSourceIndex(uint aValue)
        {
        uint changed;
            if (0 != DvProviderLinnCoUkProduct3SetPropertyProductSourceIndex(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductSourceIndex(out uint aValue)
        {
            fixed (uint* value = &aValue)
			{
                DvProviderLinnCoUkProduct3GetPropertyProductSourceIndex(iHandle, value);
            }
        }

        public unsafe bool SetPropertyProductSourceCount(uint aValue)
        {
        uint changed;
            if (0 != DvProviderLinnCoUkProduct3SetPropertyProductSourceCount(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductSourceCount(out uint aValue)
        {
            fixed (uint* value = &aValue)
			{
                DvProviderLinnCoUkProduct3GetPropertyProductSourceCount(iHandle, value);
            }
        }

        public unsafe bool SetPropertyProductSourceXml(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkProduct3SetPropertyProductSourceXml(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductSourceXml(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkProduct3GetPropertyProductSourceXml(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyStartupSourceIndex(uint aValue)
        {
        uint changed;
            if (0 != DvProviderLinnCoUkProduct3SetPropertyStartupSourceIndex(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyStartupSourceIndex(out uint aValue)
        {
            fixed (uint* value = &aValue)
			{
                DvProviderLinnCoUkProduct3GetPropertyStartupSourceIndex(iHandle, value);
            }
        }

        public unsafe bool SetPropertyStartupSourceEnabled(bool aValue)
        {
        uint changed;
            int value = (aValue ? 1 : 0);
            if (0 != DvProviderLinnCoUkProduct3SetPropertyStartupSourceEnabled(iHandle, value, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyStartupSourceEnabled(out bool aValue)
        {
            int value;
            DvProviderLinnCoUkProduct3GetPropertyStartupSourceEnabled(iHandle, &value);
            aValue = (value != 0);
        }

        public unsafe bool SetPropertyProductAnySourceName(uint aValue)
        {
        uint changed;
            if (0 != DvProviderLinnCoUkProduct3SetPropertyProductAnySourceName(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductAnySourceName(out uint aValue)
        {
            fixed (uint* value = &aValue)
			{
                DvProviderLinnCoUkProduct3GetPropertyProductAnySourceName(iHandle, value);
            }
        }

        public unsafe bool SetPropertyProductAnySourceVisible(uint aValue)
        {
        uint changed;
            if (0 != DvProviderLinnCoUkProduct3SetPropertyProductAnySourceVisible(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductAnySourceVisible(out uint aValue)
        {
            fixed (uint* value = &aValue)
			{
                DvProviderLinnCoUkProduct3GetPropertyProductAnySourceVisible(iHandle, value);
            }
        }

        public unsafe bool SetPropertyProductAnySourceType(uint aValue)
        {
        uint changed;
            if (0 != DvProviderLinnCoUkProduct3SetPropertyProductAnySourceType(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProductAnySourceType(out uint aValue)
        {
            fixed (uint* value = &aValue)
			{
                DvProviderLinnCoUkProduct3GetPropertyProductAnySourceType(iHandle, value);
            }
        }

        protected unsafe void EnableActionType()
        {
            iCallbackType = new CallbackType(DoType);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionType(iHandle, iCallbackType, ptr);
        }

        protected unsafe void EnableActionModel()
        {
            iCallbackModel = new CallbackModel(DoModel);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionModel(iHandle, iCallbackModel, ptr);
        }

        protected unsafe void EnableActionName()
        {
            iCallbackName = new CallbackName(DoName);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionName(iHandle, iCallbackName, ptr);
        }

        protected unsafe void EnableActionSetName()
        {
            iCallbackSetName = new CallbackSetName(DoSetName);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetName(iHandle, iCallbackSetName, ptr);
        }

        protected unsafe void EnableActionRoom()
        {
            iCallbackRoom = new CallbackRoom(DoRoom);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionRoom(iHandle, iCallbackRoom, ptr);
        }

        protected unsafe void EnableActionSetRoom()
        {
            iCallbackSetRoom = new CallbackSetRoom(DoSetRoom);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetRoom(iHandle, iCallbackSetRoom, ptr);
        }

        protected unsafe void EnableActionStandby()
        {
            iCallbackStandby = new CallbackStandby(DoStandby);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionStandby(iHandle, iCallbackStandby, ptr);
        }

        protected unsafe void EnableActionSetStandby()
        {
            iCallbackSetStandby = new CallbackSetStandby(DoSetStandby);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetStandby(iHandle, iCallbackSetStandby, ptr);
        }

        protected unsafe void EnableActionSourceCount()
        {
            iCallbackSourceCount = new CallbackSourceCount(DoSourceCount);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSourceCount(iHandle, iCallbackSourceCount, ptr);
        }

        protected unsafe void EnableActionSourceXml()
        {
            iCallbackSourceXml = new CallbackSourceXml(DoSourceXml);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSourceXml(iHandle, iCallbackSourceXml, ptr);
        }

        protected unsafe void EnableActionSourceIndex()
        {
            iCallbackSourceIndex = new CallbackSourceIndex(DoSourceIndex);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSourceIndex(iHandle, iCallbackSourceIndex, ptr);
        }

        protected unsafe void EnableActionSetSourceIndex()
        {
            iCallbackSetSourceIndex = new CallbackSetSourceIndex(DoSetSourceIndex);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetSourceIndex(iHandle, iCallbackSetSourceIndex, ptr);
        }

        protected unsafe void EnableActionSetSourceIndexByName()
        {
            iCallbackSetSourceIndexByName = new CallbackSetSourceIndexByName(DoSetSourceIndexByName);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetSourceIndexByName(iHandle, iCallbackSetSourceIndexByName, ptr);
        }

        protected unsafe void EnableActionSetStartupSourceIndexByName()
        {
            iCallbackSetStartupSourceIndexByName = new CallbackSetStartupSourceIndexByName(DoSetStartupSourceIndexByName);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetStartupSourceIndexByName(iHandle, iCallbackSetStartupSourceIndexByName, ptr);
        }

        protected unsafe void EnableActionStartupSourceIndex()
        {
            iCallbackStartupSourceIndex = new CallbackStartupSourceIndex(DoStartupSourceIndex);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionStartupSourceIndex(iHandle, iCallbackStartupSourceIndex, ptr);
        }

        protected unsafe void EnableActionSetStartupSourceIndex()
        {
            iCallbackSetStartupSourceIndex = new CallbackSetStartupSourceIndex(DoSetStartupSourceIndex);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetStartupSourceIndex(iHandle, iCallbackSetStartupSourceIndex, ptr);
        }

        protected unsafe void EnableActionStartupSourceEnabled()
        {
            iCallbackStartupSourceEnabled = new CallbackStartupSourceEnabled(DoStartupSourceEnabled);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionStartupSourceEnabled(iHandle, iCallbackStartupSourceEnabled, ptr);
        }

        protected unsafe void EnableActionSetStartupSourceEnabled()
        {
            iCallbackSetStartupSourceEnabled = new CallbackSetStartupSourceEnabled(DoSetStartupSourceEnabled);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetStartupSourceEnabled(iHandle, iCallbackSetStartupSourceEnabled, ptr);
        }

        protected unsafe void EnableActionSourceSystemName()
        {
            iCallbackSourceSystemName = new CallbackSourceSystemName(DoSourceSystemName);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSourceSystemName(iHandle, iCallbackSourceSystemName, ptr);
        }

        protected unsafe void EnableActionSourceName()
        {
            iCallbackSourceName = new CallbackSourceName(DoSourceName);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSourceName(iHandle, iCallbackSourceName, ptr);
        }

        protected unsafe void EnableActionSetSourceName()
        {
            iCallbackSetSourceName = new CallbackSetSourceName(DoSetSourceName);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetSourceName(iHandle, iCallbackSetSourceName, ptr);
        }

        protected unsafe void EnableActionSourceType()
        {
            iCallbackSourceType = new CallbackSourceType(DoSourceType);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSourceType(iHandle, iCallbackSourceType, ptr);
        }

        protected unsafe void EnableActionSourceVisible()
        {
            iCallbackSourceVisible = new CallbackSourceVisible(DoSourceVisible);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSourceVisible(iHandle, iCallbackSourceVisible, ptr);
        }

        protected unsafe void EnableActionSetSourceVisible()
        {
            iCallbackSetSourceVisible = new CallbackSetSourceVisible(DoSetSourceVisible);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkProduct3EnableActionSetSourceVisible(iHandle, iCallbackSetSourceVisible, ptr);
        }

        protected virtual void Type(uint aVersion, out string aaType)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Model(uint aVersion, out string aaModel)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Name(uint aVersion, out string aaName)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetName(uint aVersion, string aaName)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Room(uint aVersion, out string aaRoom)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetRoom(uint aVersion, string aaRoom)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Standby(uint aVersion, out bool aaStandby)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetStandby(uint aVersion, bool aaStandby)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SourceCount(uint aVersion, out uint aaSourceCount)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SourceXml(uint aVersion, out string aaSourceXml)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SourceIndex(uint aVersion, out uint aaSourceIndex)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetSourceIndex(uint aVersion, uint aaSourceIndex)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetSourceIndexByName(uint aVersion, string aaSourceName)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetStartupSourceIndexByName(uint aVersion, string aaSourceName)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void StartupSourceIndex(uint aVersion, out uint aaSourceIndex)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetStartupSourceIndex(uint aVersion, uint aaSourceIndex)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void StartupSourceEnabled(uint aVersion, out bool aaStartupSourceEnabled)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetStartupSourceEnabled(uint aVersion, bool aaStartupSourceEnabled)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SourceSystemName(uint aVersion, uint aaSourceIndex, out string aaSourceName)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SourceName(uint aVersion, uint aaSourceIndex, out string aaSourceName)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetSourceName(uint aVersion, uint aaSourceIndex, string aaSourceName)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SourceType(uint aVersion, uint aaSourceIndex, out string aaSourceType)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SourceVisible(uint aVersion, uint aaSourceIndex, out bool aaSourceVisible)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetSourceVisible(uint aVersion, uint aaSourceIndex, bool aaSourceVisible)
        {
            throw (new ActionDisabledError());
        }

        private static unsafe int DoType(IntPtr aPtr, uint aVersion, char** aaType)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aType;
            self.Type(aVersion, out aType);
            *aaType = (char*)Marshal.StringToHGlobalAnsi(aType).ToPointer();
            return 0;
        }

        private static unsafe int DoModel(IntPtr aPtr, uint aVersion, char** aaModel)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aModel;
            self.Model(aVersion, out aModel);
            *aaModel = (char*)Marshal.StringToHGlobalAnsi(aModel).ToPointer();
            return 0;
        }

        private static unsafe int DoName(IntPtr aPtr, uint aVersion, char** aaName)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aName;
            self.Name(aVersion, out aName);
            *aaName = (char*)Marshal.StringToHGlobalAnsi(aName).ToPointer();
            return 0;
        }

        private static unsafe int DoSetName(IntPtr aPtr, uint aVersion, char* aaName)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aName = Marshal.PtrToStringAnsi((IntPtr)aaName);
            self.SetName(aVersion, aName);
            return 0;
        }

        private static unsafe int DoRoom(IntPtr aPtr, uint aVersion, char** aaRoom)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aRoom;
            self.Room(aVersion, out aRoom);
            *aaRoom = (char*)Marshal.StringToHGlobalAnsi(aRoom).ToPointer();
            return 0;
        }

        private static unsafe int DoSetRoom(IntPtr aPtr, uint aVersion, char* aaRoom)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aRoom = Marshal.PtrToStringAnsi((IntPtr)aaRoom);
            self.SetRoom(aVersion, aRoom);
            return 0;
        }

        private static unsafe int DoStandby(IntPtr aPtr, uint aVersion, int* aaStandby)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            bool aStandby;
            self.Standby(aVersion, out aStandby);
            *aaStandby = (aStandby ? 1 : 0);
            return 0;
        }

        private static unsafe int DoSetStandby(IntPtr aPtr, uint aVersion, int aaStandby)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            bool aStandby = (aaStandby != 0);
            self.SetStandby(aVersion, aStandby);
            return 0;
        }

        private static unsafe int DoSourceCount(IntPtr aPtr, uint aVersion, uint* aaSourceCount)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            uint aSourceCount;
            self.SourceCount(aVersion, out aSourceCount);
            *aaSourceCount = aSourceCount;
            return 0;
        }

        private static unsafe int DoSourceXml(IntPtr aPtr, uint aVersion, char** aaSourceXml)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aSourceXml;
            self.SourceXml(aVersion, out aSourceXml);
            *aaSourceXml = (char*)Marshal.StringToHGlobalAnsi(aSourceXml).ToPointer();
            return 0;
        }

        private static unsafe int DoSourceIndex(IntPtr aPtr, uint aVersion, uint* aaSourceIndex)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            uint aSourceIndex;
            self.SourceIndex(aVersion, out aSourceIndex);
            *aaSourceIndex = aSourceIndex;
            return 0;
        }

        private static unsafe int DoSetSourceIndex(IntPtr aPtr, uint aVersion, uint aaSourceIndex)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            self.SetSourceIndex(aVersion, aaSourceIndex);
            return 0;
        }

        private static unsafe int DoSetSourceIndexByName(IntPtr aPtr, uint aVersion, char* aaSourceName)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aSourceName = Marshal.PtrToStringAnsi((IntPtr)aaSourceName);
            self.SetSourceIndexByName(aVersion, aSourceName);
            return 0;
        }

        private static unsafe int DoSetStartupSourceIndexByName(IntPtr aPtr, uint aVersion, char* aaSourceName)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aSourceName = Marshal.PtrToStringAnsi((IntPtr)aaSourceName);
            self.SetStartupSourceIndexByName(aVersion, aSourceName);
            return 0;
        }

        private static unsafe int DoStartupSourceIndex(IntPtr aPtr, uint aVersion, uint* aaSourceIndex)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            uint aSourceIndex;
            self.StartupSourceIndex(aVersion, out aSourceIndex);
            *aaSourceIndex = aSourceIndex;
            return 0;
        }

        private static unsafe int DoSetStartupSourceIndex(IntPtr aPtr, uint aVersion, uint aaSourceIndex)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            self.SetStartupSourceIndex(aVersion, aaSourceIndex);
            return 0;
        }

        private static unsafe int DoStartupSourceEnabled(IntPtr aPtr, uint aVersion, int* aaStartupSourceEnabled)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            bool aStartupSourceEnabled;
            self.StartupSourceEnabled(aVersion, out aStartupSourceEnabled);
            *aaStartupSourceEnabled = (aStartupSourceEnabled ? 1 : 0);
            return 0;
        }

        private static unsafe int DoSetStartupSourceEnabled(IntPtr aPtr, uint aVersion, int aaStartupSourceEnabled)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            bool aStartupSourceEnabled = (aaStartupSourceEnabled != 0);
            self.SetStartupSourceEnabled(aVersion, aStartupSourceEnabled);
            return 0;
        }

        private static unsafe int DoSourceSystemName(IntPtr aPtr, uint aVersion, uint aaSourceIndex, char** aaSourceName)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aSourceName;
            self.SourceSystemName(aVersion, aaSourceIndex, out aSourceName);
            *aaSourceName = (char*)Marshal.StringToHGlobalAnsi(aSourceName).ToPointer();
            return 0;
        }

        private static unsafe int DoSourceName(IntPtr aPtr, uint aVersion, uint aaSourceIndex, char** aaSourceName)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aSourceName;
            self.SourceName(aVersion, aaSourceIndex, out aSourceName);
            *aaSourceName = (char*)Marshal.StringToHGlobalAnsi(aSourceName).ToPointer();
            return 0;
        }

        private static unsafe int DoSetSourceName(IntPtr aPtr, uint aVersion, uint aaSourceIndex, char* aaSourceName)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aSourceName = Marshal.PtrToStringAnsi((IntPtr)aaSourceName);
            self.SetSourceName(aVersion, aaSourceIndex, aSourceName);
            return 0;
        }

        private static unsafe int DoSourceType(IntPtr aPtr, uint aVersion, uint aaSourceIndex, char** aaSourceType)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            string aSourceType;
            self.SourceType(aVersion, aaSourceIndex, out aSourceType);
            *aaSourceType = (char*)Marshal.StringToHGlobalAnsi(aSourceType).ToPointer();
            return 0;
        }

        private static unsafe int DoSourceVisible(IntPtr aPtr, uint aVersion, uint aaSourceIndex, int* aaSourceVisible)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            bool aSourceVisible;
            self.SourceVisible(aVersion, aaSourceIndex, out aSourceVisible);
            *aaSourceVisible = (aSourceVisible ? 1 : 0);
            return 0;
        }

        private static unsafe int DoSetSourceVisible(IntPtr aPtr, uint aVersion, uint aaSourceIndex, int aaSourceVisible)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkProduct3 self = (DvProviderLinnCoUkProduct3)gch.Target;
            bool aSourceVisible = (aaSourceVisible != 0);
            self.SetSourceVisible(aVersion, aaSourceIndex, aSourceVisible);
            return 0;
        }


        public void Dispose()
        {
            DoDispose();
            GC.SuppressFinalize(this);
        }

        ~DvProviderLinnCoUkProduct3()
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
            DvProviderLinnCoUkProduct3Destroy(handle);
            if (iGch.IsAllocated)
            {
                iGch.Free();
            }
        }
    }
}

