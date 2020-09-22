using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            int a = 1, b = 2, result = 3;
            sumtest s = new sumtest();
            int sum =s.add(a, b);
            Assert.AreEqual(sum, result); //Assert 断言

        }

        [TestMethod]
        public void TestMethod2()
        {
            float a = 1.5f, b = 2.5f, result = 3.75f;
            sumtest s = new sumtest();
            float ji = s.cheng(a, b);
            Assert.AreEqual(ji, result); //Assert 断言

        }
    }
}
