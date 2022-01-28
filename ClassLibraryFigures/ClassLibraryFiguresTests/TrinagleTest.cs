using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Figures;

namespace ClassLibraryFiguresTests
{
    [TestClass]
    public class TrinagleTest
    {
        [TestMethod]
        public void TriangleTest1()
        {
            // arrange
            double ab = 1;
            double bc = 2;
            double ca = 3;
            double expectedArea = 0;
            bool expectedRectangularity = false;

            // act
            Triangle triangle = new Triangle(ab,bc,ca);
            double actualArea = triangle.GetАrea();
            bool actualRectangularity = triangle.IsRectangular();

            // assert
            Assert.AreEqual(expectedArea, actualArea);
            Assert.AreEqual(expectedRectangularity, actualRectangularity);
        }

        [TestMethod]
        public void TriangleTest2()
        {
            // arrange
            double ab = 5;
            double bc = 5;
            double ca = 3;
            int expectedArea = 7;
            bool expectedRectangularity = false;

            // act
            Triangle triangle = new Triangle(ab, bc, ca);
            double actualArea = (int) triangle.GetАrea();
            bool actualRectangularity = triangle.IsRectangular();

            // assert
            Assert.AreEqual(expectedArea, actualArea);
            Assert.AreEqual(expectedRectangularity, actualRectangularity);
        }

        [TestMethod]
        public void TriangleTest3()
        {
            // arrange
            double ab = 8;
            double bc = 6;
            double ca = 10;
            int expectedArea = 24;
            bool expectedRectangularity = true;

            // act
            Triangle triangle = new Triangle(ab, bc, ca);
            double actualArea = (int)triangle.GetАrea();
            bool actualRectangularity = triangle.IsRectangular();

            // assert
            Assert.AreEqual(expectedArea, actualArea);
            Assert.AreEqual(expectedRectangularity, actualRectangularity);
        }
    }
}
