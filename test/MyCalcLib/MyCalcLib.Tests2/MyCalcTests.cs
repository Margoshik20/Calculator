using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests2
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Min_20and_5_15returned()
        {
            //arrange
            int label2 = 20;
            int textbox2 = 5;
            int end2 = 15;

            //act
            MyCalc s = new MyCalc();
            int actual = s.Min(label2, textbox2);
            //assert

            Assert.AreEqual(end2, actual);
        }
    }
}
