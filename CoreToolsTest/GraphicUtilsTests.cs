using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Versioning;

namespace CoreToolsTest
{
    [TestClass]
    public class GraphicUtilsTests
    {
        [TestMethod]
        public void GetCursorPos()
        {
            Point pos = CoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
        }

        [TestMethod]
        public void GetPixelColorAtCursorPosR()
        {
            Point pos = CoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = CoreTools.GraphicUtils.GetPixelColorAtCursorPos();
            Color testColor = Color.FromArgb(255, 0, 0); //FFFF0000
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(color, testColor);
        }

        [TestMethod]
        public void GetPixelColorAtCursorPosG()
        {
            Point pos = CoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = CoreTools.GraphicUtils.GetPixelColorAtCursorPos();
            Color testColor = Color.FromArgb(0, 255, 0); //FF00FF00
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(color, testColor);
        }

        [TestMethod]
        public void GetPixelColorAtCursorPosB()
        {
            Point pos = CoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = CoreTools.GraphicUtils.GetPixelColorAtCursorPos();
            Color testColor = Color.FromArgb(0, 0, 255); //FF0000FF
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(color, testColor);
        }

        [TestMethod]
        [SupportedOSPlatform("windows")]
        public void GetPixelColorAtCursorPosR2()
        {
            Point pos = CoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = CoreTools.GraphicUtils.GetPixelColorAtCursorPos(true);
            Color testColor = Color.FromArgb(255, 0, 0); //FFFF0000
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(color, testColor);
        }

        [TestMethod]
        [SupportedOSPlatform("windows")]
        public void GetPixelColorAtCursorPosG2()
        {
            Point pos = CoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = CoreTools.GraphicUtils.GetPixelColorAtCursorPos(true);
            Color testColor = Color.FromArgb(0, 255, 0); //FF00FF00
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(color, testColor);
        }

        [TestMethod]
        [SupportedOSPlatform("windows")]
        public void GetPixelColorAtCursorPosB2()
        {
            Point pos = CoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = CoreTools.GraphicUtils.GetPixelColorAtCursorPos(true);
            Color testColor = Color.FromArgb(0, 0, 255); //FF0000FF
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(color, testColor);
        }

        [TestMethod]
        [SupportedOSPlatform("windows")]
        public void CaptureScreenshotAtCursorPos()
        {
            Bitmap bitmap = CoreTools.GraphicUtils.CaptureScreenshotAtCursorPos(new Size(2, 8));
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Debug.WriteLine($"Color ({i},{j}): " + bitmap.GetPixel(i, j));
                }
            }
        }

        [TestMethod]
        [SupportedOSPlatform("windows")]
        public void CaptureScreenshotAtCursorPosWithOffset()
        {
            Bitmap bitmap = CoreTools.GraphicUtils.CaptureScreenshotAtCursorPos(new Size(2, 8), new Size(10, 0));
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Debug.WriteLine($"Color ({i},{j}): " + bitmap.GetPixel(i, j));
                }
            }
        }
    }
}
