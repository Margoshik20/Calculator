using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcTests3
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Del_80_4and_20returned()
        {
            //arrange
            int label3 = 10;
            int textbox3 = 20;
            int end1 = 30;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(label3, textbox3);
            //assert

            Assert.AreEqual(end1, actual);
        }
    }
}
