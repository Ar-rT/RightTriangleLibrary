using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangle
{
    public static class RightTriangleMath
    {
        /// <summary>
        /// Calculates area of right trangle square
        /// </summary>
        /// <param name="side1Length">length of first side</param>
        /// <param name="side2Length">length of second side</param>
        /// <param name="side3Length">length of third side</param>
        public static Double Area(Double side1Length, Double side2Length, Double side3Length)
        {
            var sidesLength = new[] { side1Length, side2Length, side3Length };
            var hypotenuse = sidesLength.Max();
            try
            {
                sidesLength.Single(l => DoubleEquals(l, hypotenuse));//checks if there is only one side with maximum length
            }
            catch (System.InvalidOperationException)
            {
                throw new ArgumentException("Wrong sides length");
            }
            if (!DoubleEquals(hypotenuse, Math.Sqrt(sidesLength.Where(l => l != hypotenuse).Select(l => Math.Pow(l, 2)).Sum())))//checks Pythagorean theorem
                throw new ArgumentException("Wrong sides length, does not satisfy the Pythagorean theorem");
            return 0.5 * sidesLength.Where(l => !DoubleEquals(l, hypotenuse)).Aggregate((cathetus1, cathetus2) => cathetus1 * cathetus2);
        }

        private static bool DoubleEquals(double first, double second)
        {
            return Math.Abs(first - second) <= Double.Epsilon;
        }
    }
}
