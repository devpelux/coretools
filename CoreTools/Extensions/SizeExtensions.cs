using System.Drawing;

namespace CoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="Size"/> extensions.
    /// </summary>
    public static class SizeExtensions
    {
        /// <summary>
        /// Inverts the <see cref="Size"/> by replacing every value with its negative.
        /// </summary>
        /// <param name="size">Current <see cref="Size"/>.</param>
        /// <returns>
        /// The current <see cref="Size"/> with the opposite values for <b>width</b> and <b>height</b>.
        /// </returns>
        public static Size Invert(this Size size) => new(-size.Width, -size.Height);

        /// <summary>
        /// Initializes a new <see cref="Size"/> with uniform dimensions.
        /// </summary>
        /// <param name="dim">Dimensions.</param>
        /// <returns>New <see cref="Size"/> with uniform dimensions.</returns>
        public static Size UniformSize(int dim) => new(dim, dim);
    }
}
