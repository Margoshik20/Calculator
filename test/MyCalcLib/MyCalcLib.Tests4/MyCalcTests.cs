using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests4
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Ymn_4and_20_80returned()
        {
            //arrange
            int label4 = 4;
            int textbox4 = 20;
            int end4 = 80;

            //act
            MyCalc k = new MyCalc();
            int actual = k.Ymn(label4, textbox4);
            //assert

            Assert.AreEqual(end4, actual);
        }
    }
}
