using CoreTools.Core;
using System.Drawing;

namespace CoreTools
{
    /// <summary>
    /// Provides a set of graphic utilities.
    /// </summary>
    public static class GraphicUtils
    {
        /// <summary>
        /// Gets the current cursor position on display.
        /// </summary>
        /// <returns>Current cursor position on display.</returns>
        public static Point GetCursorPos()
        {
            NativeMethods.GetCursorPos(out POINT lMousePosition);
            return lMousePosition;
        }
    }
}
