using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask_Form.com;

namespace TestTestTask_Form.com
{
    [TestClass]
    public class UnitTest1
    {
        private Figure figure;

        [TestMethod]
        public void TestEquilateralType()
        {
            this.figure = new Figure();

            int a = 2;
            int b = 2;
            int c = 2;

            Assert.AreEqual(figure.TriangleType(a, b, c), 3);
        }

        [TestMethod]
        public void TestIsoscelesType_ABSidesAreEqual()
        {
            this.figure = new Figure();

            int a = 2;
            int b = 2;
            int c = 3;

            Assert.AreEqual(figure.TriangleType(a, b, c), 2);
        }

        [TestMethod]
        public void TestIsoscelesType_ACSidesAreEqual()
        {
            this.figure = new Figure();

            int a = 2;
            int b = 4;
            int c = 2;

            Assert.AreEqual(figure.TriangleType(a, b, c), 2);
        }

        [TestMethod]
        public void TestIsoscelesType_BCSidesAreEqual()
        {
            this.figure = new Figure();

            int a = 1;
            int b = 2;
            int c = 2;

            Assert.AreEqual(figure.TriangleType(a, b, c), 2);
        }

        [TestMethod]
        public void TestScaleneType()
        {
            this.figure = new Figure();

            int a = 1;
            int b = 2;
            int c = 3;

            Assert.AreEqual(figure.TriangleType(a, b, c), 1);
        }

        [TestMethod]
        public void TestError_AIsNegativeValue()
        {
            this.figure = new Figure();

            int a = -1;
            int b = 2;
            int c = 3;

            Assert.AreEqual(figure.TriangleType(a, b, c), 4);
        }

        [TestMethod]
        public void TestError_CIsZeroValue()
        {
            this.figure = new Figure();

            int a = 3;
            int b = 2;
            int c = 0;

            Assert.AreEqual(figure.TriangleType(a, b, c), 4);
        }
    }
}
