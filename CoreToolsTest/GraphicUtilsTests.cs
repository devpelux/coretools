using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Drawing;

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
    }
}
