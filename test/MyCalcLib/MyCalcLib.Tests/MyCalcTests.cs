using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and_20_30returned()
        {
            //arrange
            int label1 = 10;
            int textbox1 = 20;
           int end1 = 30;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(label1, textbox1);
            //assert

            Assert.AreEqual(end1, actual);

        }
       

    }
}
