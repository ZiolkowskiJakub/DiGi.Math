using DiGi.Math.Classes;
using MathNet.Numerics;
using System.Collections.Generic;

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

            // Materialize each sequence once instead of re-enumerating it for every Count() call.
            double[] doubles_X = [.. x];
            double[] doubles_Y = [.. y];

            int count = doubles_X.Length;
            if (count <= 1 || doubles_Y.Length != count)
            {
                return null;
            }

            int order_Temp = order == -1 ? count - 1 : order;

            Polynomial polynomial = Polynomial.Fit(doubles_X, doubles_Y, order_Temp, MathNet.Numerics.LinearRegression.DirectRegressionMethod.NormalEquations);
            return polynomial?.ToDiGi();
        }
    }
}