using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ConsoleApp1test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Addition()
        {
            int a = 650;
            int b = 60;
            int result = Program.Example(a, b);
            Assert.AreEqual(9, result);
        }
    }
}
