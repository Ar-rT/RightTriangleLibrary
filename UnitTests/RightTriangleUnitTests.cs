using System;
using RightTriangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class RightTriangleUnitTests
    {
        [TestMethod]
        public void RightTriangleAreaTests()
        {
            Double Side1 = 4;
            Double Side2 = 5;
            Double Side3 = Math.Sqrt(Math.Pow(Side1,2) + Math.Pow(Side2,2));
            RightTriangleMath.Area(Side1, Side2, Side3);//Right parameters
            Side1 = 10;
            Side2 = 10;
            Side3 = 10;
            try
            {
                RightTriangleMath.Area(Side1, Side2, Side3);
            }
            catch (ArgumentException)//All sides are the same length
                {
                }
            Side1 = 7;
            Side2 = 8;
            Side3 = 9;
            try
            {
                RightTriangleMath.Area(Side1, Side2, Side3);
            }
            catch (ArgumentException)//Does not satisfy the Pythagorean theorem
            {
            }
        }
    }
}
