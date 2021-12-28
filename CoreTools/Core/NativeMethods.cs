using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CoreTools.Core
{
    /// <summary>
    /// External native methods.
    /// </summary>
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern int GetModuleFileName(IntPtr hModule, StringBuilder buffer, int length);
    }
}
