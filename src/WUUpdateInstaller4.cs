using System.Runtime.InteropServices;

namespace PSWindowsUpdate
{
    /// <summary>
    /// Minimal COM interface for IUpdateInstaller4 (GUID ef8208ea-2304-492d-9109-23813b0958e1).
    /// IUpdateInstaller4 is not exposed by the WUApiLib v2.0 COM interop, so it must be
    /// declared manually with the correct vtable layout.
    ///
    /// The vtable layout (InterfaceIsIUnknown, slots after IUnknown's 3 methods):
    ///   Slots 0-3  : IDispatch (GetTypeInfoCount, GetTypeInfo, GetIDsOfNames, Invoke)
    ///   Slots 4-28 : IUpdateInstaller / IUpdateInstaller2 / IUpdateInstaller3 methods
    ///   Slot  29   : Commit
    ///
    /// See: https://stackoverflow.com/a/75265447 (CC BY-SA 4.0, Dimitri Rodis)
    /// </summary>
    [ComImport]
    [Guid("ef8208ea-2304-492d-9109-23813b0958e1")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IWUUpdateInstaller4
    {
        // Skips 4 IDispatch slots + 25 IUpdateInstaller/2/3 slots = 29 vtable entries
        void _VtblGap0_29();

        [PreserveSig]
        int Commit(uint dwFlags);
    }
}
