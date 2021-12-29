using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
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
        private const int RC_NONE = 0;

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

        [SupportedOSPlatform("windows")]
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

        [SupportedOSPlatform("windows")]
        internal static Bitmap CaptureScreenshot(Point pos, Size size)
        {
            Bitmap screenshot = new(size.Width, size.Height, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(screenshot))
            {
                gdest.CopyFromScreen(pos.X, pos.Y, 0, 0, screenshot.Size, CopyPixelOperation.SourceCopy);
            }
            return screenshot;
        }

        internal static Color GetPixelColor(Point pos, bool takeScreenshotWhenPossible = false)
        {
            if (takeScreenshotWhenPossible && RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return GetPixelColorV2(pos);
            else
            {
                try
                {
                    return GetPixelColorV1(pos);
                }
                catch (NotSupportedException)
                {
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return GetPixelColorV2(pos);
                    else throw new NotSupportedException("GetPixelColor(Point) not supported.");
                }
            }
        }

        private static Color GetPixelColorV1(Point pos)
        {
            IntPtr desktop = NativeMethods.GetDesktopWindow();
            IntPtr dc = NativeMethods.GetWindowDC(desktop);
            if (NativeMethods.GetDeviceCaps(dc, (int)DeviceCap.RASTERCAPS) != RC_NONE)
            {
                int color = (int)NativeMethods.GetPixel(dc, pos.X, pos.Y);
                _ = NativeMethods.ReleaseDC(desktop, dc);
                return Color.FromArgb(255, (color >> 0) & 0xff, (color >> 8) & 0xff, (color >> 16) & 0xff);
            }
            else
            {
                _ = NativeMethods.ReleaseDC(desktop, dc);
                throw new NotSupportedException("GetPixel(IntPtr, int, int) not supported.");
            }
        }

        [SupportedOSPlatform("windows")]
        private static Color GetPixelColorV2(Point pos)
        {
            return CaptureScreenshot(pos, new Size(1, 1)).GetPixel(0, 0);
        }
    }
}
