using DiGi.Math.Classes;
using MathNet.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Math
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a polynomial equation that fits the given data points.
        /// </summary>
        /// <param name="x">The x coordinates of the data points.</param>
        /// <param name="y">The y coordinates of the data points.</param>
        /// <param name="order">The order of the polynomial. If -1, it uses count - 1.</param>
        /// <returns>A PolynomialEquation that fits the data, or null if fitting fails.</returns>
        public static PolynomialEquation? PolynomialEquation(IEnumerable<double>? x, IEnumerable<double>? y, int order = -1)
        {
            if (x == null || y == null)
            {
                return null;
            }

            int count = x.Count();
            if (count == 0 || y.Count() != count)
            {
                return null;
            }

            if (x.Count() == 1)
            {
                return null;
            }

            int order_Temp = order;
            if (order_Temp == -1)
            {
                order_Temp = count - 1;
            }

            Polynomial polynomial = Polynomial.Fit([.. x], [.. y], order_Temp, MathNet.Numerics.LinearRegression.DirectRegressionMethod.NormalEquations);
            return polynomial?.ToDiGi();
        }
    }
}