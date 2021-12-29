using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace CoreToolsTest
{
    [TestClass]
    public class SystemUtilsTests
    {
        [TestMethod]
        public void GetExecutingDirectory()
        {
            string path = CoreTools.SystemUtils.GetExecutingDirectory().FullName;
            Debug.WriteLine(path);            
        }
    }
}
