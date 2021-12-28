using System.Drawing;
using System.Runtime.InteropServices;

namespace CoreTools.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct POINT
    {
        public static POINT Empty;

        public int X;
        public int Y;


        static POINT() => Empty = new POINT();

        public POINT(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator Point(POINT p) => new(p.X, p.Y);

        public static explicit operator POINT(Point p) => new(checked(p.X), checked(p.Y));
    }
}
