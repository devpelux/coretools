using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace CoreTools.Core
{
    /// <summary>
    /// Internal service methods.
    /// </summary>
    internal static class InternalMethods
    {
        private const int MAX_PATH = 260;
        private const int MAX_UNICODESTRING_LEN = short.MaxValue;
        private const int INSUFFICIENT_BUFFER_ERROR = 0x007A;

        private static string? _moduleFileNameLongPath = null;


        internal static string GetExecutablePath()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return GetModuleFileNameLongPath();
            else
            {
                ProcessModule? main = Process.GetCurrentProcess().MainModule;
                return main != null ? main.FileName ?? string.Empty : string.Empty;
            }
        }

        private static string GetModuleFileNameLongPath()
        {
            if (_moduleFileNameLongPath == null)
            {
                StringBuilder buffer = new(MAX_PATH);
                int length, noOfTimes = 1;
                // Iterating by allocating chunk of memory each time we find the length is not sufficient.
                // Performance should not be an issue for current MAX_PATH length due to this change.
                while (((length = NativeMethods.GetModuleFileName(IntPtr.Zero, buffer, buffer.Capacity)) == buffer.Capacity) &&
                       Marshal.GetLastWin32Error() == INSUFFICIENT_BUFFER_ERROR &&
                       buffer.Capacity < MAX_UNICODESTRING_LEN)
                {
                    noOfTimes += 2; // Increasing buffer size by 520 in each iteration.
                    int capacity = noOfTimes * MAX_PATH < MAX_UNICODESTRING_LEN ? noOfTimes * MAX_PATH : MAX_UNICODESTRING_LEN;
                    buffer.EnsureCapacity(capacity);
                }

                buffer.Length = length;
                _moduleFileNameLongPath = Path.GetFullPath(buffer.ToString());
            }
            return _moduleFileNameLongPath;
        }
    }
}
