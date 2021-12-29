using CoreTools.Core;
using System.Drawing;
using System.Runtime.Versioning;

namespace CoreTools
{
    /// <summary>
    /// Provides a set of utilities for handling some gdi operations.
    /// </summary>
    public static class GDIUtils
    {
        /// <summary>
        /// Returns the color of the pixel at a specified position.
        /// </summary>
        /// <param name="pos">Position of the pixel from to get the color.</param>
        /// <param name="takeScreenshotWhenPossible">Take a screenshot when possible to get the pixel color
        /// (this may be slower and is supported only in Windows).</param>
        /// <returns>Color of the pixel at the specified position.</returns>
        public static Color GetPixelColor(Point pos, bool takeScreenshotWhenPossible = false)
            => InternalMethods.GetPixelColor(pos, takeScreenshotWhenPossible);

        /// <summary>
        /// Returns the color of the pixel at the current cursor position on display.
        /// </summary>
        /// <param name="takeScreenshotWhenPossible">Take a screenshot when possible to get the pixel color
        /// (this may be slower and is supported only in Windows).</param>
        /// <returns>Color of the pixel at the current cursor position on display.</returns>
        public static Color GetPixelColorAtCursorPos(bool takeScreenshotWhenPossible = false)
            => GetPixelColor(GraphicUtils.GetCursorPos(), takeScreenshotWhenPossible);

        /// <summary>
        /// Captures a screenshot from a specified position, with a specified size.
        /// </summary>
        /// <param name="pos">Top-left corner of the screenshot.</param>
        /// <param name="size">Size of the screenshot.</param>
        /// <returns>Screenshot as a <see cref="Bitmap"/>.</returns>
        [SupportedOSPlatform("windows")]
        public static Bitmap CaptureScreenshot(Point pos, Size size)
            => InternalMethods.CaptureScreenshot(pos, size);

        /// <summary>
        /// Captures a screenshot from the current cursor position on display, with a specified size, and offset.
        /// </summary>
        /// <param name="size">Size of the screenshot.</param>
        /// <param name="offset">Offset of the screenshot.</param>
        /// <returns>Screenshot as a <see cref="Bitmap"/>.</returns>
        [SupportedOSPlatform("windows")]
        public static Bitmap CaptureScreenshotAtCursorPos(Size size, Size offset)
            => CaptureScreenshot(GraphicUtils.GetCursorPos() + offset, size);

        /// <summary>
        /// Captures a screenshot from the current cursor position on display, with a specified size.
        /// </summary>
        /// <param name="size">Size of the screenshot.</param>
        /// <returns>Screenshot as a <see cref="Bitmap"/>.</returns>
        [SupportedOSPlatform("windows")]
        public static Bitmap CaptureScreenshotAtCursorPos(Size size)
            => CaptureScreenshotAtCursorPos(size, Size.Empty);
    }
}
