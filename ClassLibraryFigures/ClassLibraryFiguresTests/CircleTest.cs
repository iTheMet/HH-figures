using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Figures;

namespace FiguresTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetAreaTest_1()
        {
            // arrange
            double expected = Math.PI * Math.Pow(5, 2);

            // act
            Circle circle = new Circle(5);
            double actual = circle.GetАrea();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAreaTest_2()
        {
            // arrange
            double expected = Math.PI * Math.Pow(5.00321, 2);

            // act
            Circle circle = new Circle(5.00321);
            double actual = circle.GetАrea();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
