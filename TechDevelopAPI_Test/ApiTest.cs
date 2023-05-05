using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TechDevelopAPI.Services;

namespace TechDevelopAPI_Test
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void Test()
        {
            double expectedRightTriangle = 6;
            double expectedEvenTriangle = 3.897114;
            double expectedCircle = 12.566370614359172;

            var actualRightTriangle = SquarableFactory.GetSquare(new List<double> { 3, 4, 5 });
            var actualEvenTriangle = SquarableFactory.GetSquare(new List<double> { 3, 3, 3 });
            var actualCircle = SquarableFactory.GetSquare(new List<double> { 2 });

            Assert.AreEqual(expectedRightTriangle, actualRightTriangle, 0.00001);
            Assert.AreEqual(expectedEvenTriangle, actualEvenTriangle, 0.00001);
            Assert.AreEqual(expectedCircle, actualCircle, 0.00001);
        }
    }
}