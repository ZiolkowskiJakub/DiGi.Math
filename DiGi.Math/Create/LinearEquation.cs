using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a LinearEquation that passes through two points (x1, y1) and (x2, y2).
        /// </summary>
        /// <param name="x_1">The x-coordinate of the first point.</param>
        /// <param name="y_1">The y-coordinate of the first point.</param>
        /// <param name="x_2">The x-coordinate of the second point.</param>
        /// <param name="y_2">The y-coordinate of the second point.</param>
        /// <returns>A LinearEquation, or null if points are invalid or vertical.</returns>
        public static LinearEquation? LinearEquation(double x_1, double y_1, double x_2, double y_2)
        {
            if (double.IsNaN(x_1) || double.IsNaN(x_2) || double.IsNaN(y_1) || double.IsNaN(y_2))
            {
                return null;
            }

            double x = x_2 - x_1;
            if (x == 0)
            {
                return null;
            }

            double a = (y_2 - y_1) / x;
            if (double.IsNaN(a))
            {
                return null;
            }

            double ax = a * x_1;
            double y = y_1;
            if (ax == 0)
            {
                ax = a * x_2;
                y = y_2;
            }

            if (ax == 0)
            {
                return null;
            }

            double b = y - ax;
            return new LinearEquation(a, b);
        }
    }
}