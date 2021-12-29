using System.Drawing;

namespace CoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="Color"/> extensions.
    /// </summary>
    public static class ColorExtensions
    {
        /// <summary>
        /// Inverts the color by subtracting every value R, G, B from 255.
        /// </summary>
        /// <param name="color">Colore.</param>
        /// <returns>Inverted color.</returns>
        public static Color Invert(this Color color)
            => Color.FromArgb((byte)(255 - color.R), (byte)(255 - color.G), (byte)(255 - color.B));
    }
}
