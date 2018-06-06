using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests3
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Del_80and_20_4returned()
        {
            //arrange
            int label3 = 80;
            int textbox3 = 20;
            int end3 = 4;

            //act
            MyCalc k = new MyCalc();
            int actual = k.Del(label3, textbox3);
            //assert

            Assert.AreEqual(end3, actual);
        }
    }
}
