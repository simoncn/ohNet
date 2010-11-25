using System;
using System.Runtime.InteropServices;

namespace Zapp.ControlPoint
{
    /// <summary>
    /// List of all UPnP devices on the current subnet
    /// </summary>
    public class CpDeviceListUpnpAll : CpDeviceList
    {
        [DllImport ("ZappUpnp")]
        static extern unsafe uint CpDeviceListCreateUpnpAll(CallbackDevice aAdded, IntPtr aPtrAdded,
                                                            CallbackDevice aRemoved, IntPtr aPtrRemoved);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aAdded">Delegate which will be run when a new device is detected.
        /// Clients who are interested this new device should call AddRef() on it and add it to some local collection.
        /// This callback will never be run for a device that is already in the list.</param>
        /// <param name="aRemoved">Delegatewhich will be run when a device is removed from the network.
        /// Clients who had previously stored a reference to the device in their aAdded callback should call RemoveRef()
        /// and remove the device from their local collection.
        /// Clients who had not previously claimed a reference to a device must not call ReleaseRef().</param>
        public unsafe CpDeviceListUpnpAll(ChangeHandler aAdded, ChangeHandler aRemoved)
        {
            iAdded = aAdded;
            iRemoved = aRemoved;
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            iHandle = CpDeviceListCreateUpnpAll(iFnAdded, ptr, iFnRemoved, ptr);
        }
    }

    /// <summary>
    /// List of all root UPnP devices on the current subnet
    /// </summary>
    public class CpDeviceListUpnpRoot : CpDeviceList
    {
        [DllImport ("ZappUpnp")]
        static extern unsafe uint CpDeviceListCreateUpnpRoot(CallbackDevice aAdded, IntPtr aPtrAdded,
                                                             CallbackDevice aRemoved, IntPtr aPtrRemoved);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aAdded">Delegate which will be run when a new device is detected.
        /// Clients who are interested this new device should call AddRef() on it and add it to some local collection.
        /// This callback will never be run for a device that is already in the list.</param>
        /// <param name="aRemoved">Delegatewhich will be run when a device is removed from the network.
        /// Clients who had previously stored a reference to the device in their aAdded callback should call RemoveRef()
        /// and remove the device from their local collection.
        /// Clients who had not previously claimed a reference to a device must not call ReleaseRef().</param>
        public unsafe CpDeviceListUpnpRoot(ChangeHandler aAdded, ChangeHandler aRemoved)
        {
            iAdded = aAdded;
            iRemoved = aRemoved;
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            iHandle = CpDeviceListCreateUpnpRoot(iFnAdded, ptr, iFnRemoved, ptr);
        }
    }

    /// <summary>
    /// List of all UPnP devices with a given uuid (udn) on the current subnet
    /// </summary>
    public class CpDeviceListUpnpUuid : CpDeviceList
    {
        [DllImport ("ZappUpnp", CharSet = CharSet.Ansi)]
        static extern unsafe uint CpDeviceListCreateUpnpUuid(char* aUuid,
                                                             CallbackDevice aAdded, IntPtr aPtrAdded,
                                                             CallbackDevice aRemoved, IntPtr aPtrRemoved);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aAdded">Delegate which will be run when a new device is detected.
        /// Clients who are interested this new device should call AddRef() on it and add it to some local collection.
        /// This callback will never be run for a device that is already in the list.</param>
        /// <param name="aRemoved">Delegatewhich will be run when a device is removed from the network.
        /// Clients who had previously stored a reference to the device in their aAdded callback should call RemoveRef()
        /// and remove the device from their local collection.
        /// Clients who had not previously claimed a reference to a device must not call ReleaseRef().</param>
        public unsafe CpDeviceListUpnpUuid(String aUuid, ChangeHandler aAdded, ChangeHandler aRemoved)
        {
            iAdded = aAdded;
            iRemoved = aRemoved;
            char* uuid = (char*)Marshal.StringToHGlobalAnsi(aUuid).ToPointer();
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            iHandle = CpDeviceListCreateUpnpUuid(uuid, iFnAdded, ptr, iFnRemoved, ptr);
            Marshal.FreeHGlobal((IntPtr)uuid);
        }
    }

    /// <summary>
    /// List of all UPnP devices of a given device type on the current subnet
    /// </summary>
    public class CpDeviceListUpnpDeviceType : CpDeviceList
    {
        [DllImport ("ZappUpnp", CharSet = CharSet.Ansi)]
        static extern unsafe uint CpDeviceListCreateUpnpDeviceType(char* aDomainName, char* aDeviceType, uint aVersion,
                                                                   CallbackDevice aAdded, IntPtr aPtrAdded,
                                                                   CallbackDevice aRemoved, IntPtr aPtrRemoved);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aAdded">Delegate which will be run when a new device is detected.
        /// Clients who are interested this new device should call AddRef() on it and add it to some local collection.
        /// This callback will never be run for a device that is already in the list.</param>
        /// <param name="aRemoved">Delegatewhich will be run when a device is removed from the network.
        /// Clients who had previously stored a reference to the device in their aAdded callback should call RemoveRef()
        /// and remove the device from their local collection.
        /// Clients who had not previously claimed a reference to a device must not call ReleaseRef().</param>
        public unsafe CpDeviceListUpnpDeviceType(String aDomainName, String aDeviceType, uint aVersion,
                                                 ChangeHandler aAdded, ChangeHandler aRemoved)
        {
            iAdded = aAdded;
            iRemoved = aRemoved;
            char* domain = (char*)Marshal.StringToHGlobalAnsi(aDomainName).ToPointer();
            char* type = (char*)Marshal.StringToHGlobalAnsi(aDeviceType).ToPointer();
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            iHandle = CpDeviceListCreateUpnpDeviceType(domain, type, aVersion, iFnAdded, ptr, iFnRemoved, ptr);
            Marshal.FreeHGlobal((IntPtr)domain);
            Marshal.FreeHGlobal((IntPtr)type);
        }
    }

    /// <summary>
    /// List of all UPnP devices of a given service type on the current subnet
    /// </summary>
    public class CpDeviceListUpnpServiceType : CpDeviceList
    {
        [DllImport ("ZappUpnp", CharSet = CharSet.Ansi)]
        static extern unsafe uint CpDeviceListCreateUpnpServiceType(char* aDomainName, char* aServiceType, uint aVersion,
                                                                    CallbackDevice aAdded, IntPtr aPtrAdded,
                                                                    CallbackDevice aRemoved, IntPtr aPtrRemoved);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aAdded">Delegate which will be run when a new device is detected.
        /// Clients who are interested this new device should call AddRef() on it and add it to some local collection.
        /// This callback will never be run for a device that is already in the list.</param>
        /// <param name="aRemoved">Delegatewhich will be run when a device is removed from the network.
        /// Clients who had previously stored a reference to the device in their aAdded callback should call RemoveRef()
        /// and remove the device from their local collection.
        /// Clients who had not previously claimed a reference to a device must not call ReleaseRef().</param>
        public unsafe CpDeviceListUpnpServiceType(String aDomainName, String aServiceType, uint aVersion,
                                                  ChangeHandler aAdded, ChangeHandler aRemoved)
        {
            iAdded = aAdded;
            iRemoved = aRemoved;
            char* domain = (char*)Marshal.StringToHGlobalAnsi(aDomainName).ToPointer();
            char* type = (char*)Marshal.StringToHGlobalAnsi(aServiceType).ToPointer();
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            iHandle = CpDeviceListCreateUpnpServiceType(domain, type, aVersion, iFnAdded, ptr, iFnRemoved, ptr);
            Marshal.FreeHGlobal((IntPtr)domain);
            Marshal.FreeHGlobal((IntPtr)type);
        }
    }
}
