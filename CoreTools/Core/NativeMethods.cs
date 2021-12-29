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

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern int GetModuleFileName(IntPtr hModule, StringBuilder buffer, int length);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr GetWindowDC(IntPtr window);

        [DllImport("gdi32.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern uint GetPixel(IntPtr dc, int x, int y);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int ReleaseDC(IntPtr window, IntPtr dc);
    }
}
