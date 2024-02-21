using System;
using NUnit.Framework;
using The_area_circle_and_triangle;

namespace The_area_circle_and_triangle_Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestCircleArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            Assert.AreEqual(expectedArea, The_area_circle_and_triangle_c.CalculateCircleArea(radius) , 0.0001);
        }
        [Test]
        public void TestTriangleArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, The_area_circle_and_triangle_c.CalculateTriangleArea(side1, side2, side3), 0.0001);
        }
        [Test]
        public void TestRightTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Assert.IsTrue(The_area_circle_and_triangle_c.IsRightTriangle(side1, side2, side3));
        }
    }
}
