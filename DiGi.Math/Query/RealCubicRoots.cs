namespace DiGi.Math
{
    public static partial class Query
    {
        //Solve cubic equation: ax^3 + bx^2 + cx + d = 0 according to Cardano.
        //Source: https://www.cs.rit.edu/~ark/pj/lib/edu/rit/numeric/Cubic.shtml
        /// <summary>
        /// Solves a cubic equation of the form ax³ + bx² + cx + d = 0 using Cardano's method.
        /// </summary>
        /// <param name="a">The coefficient of the x³ term.</param>
        /// <param name="b">The coefficient of the x² term.</param>
        /// <param name="c">The coefficient of the x term.</param>
        /// <param name="d">The constant term.</param>
        /// <returns>An array containing the real roots of the equation, or null if no real roots are found.</returns>
        public static double[]? RealCubricRoots(double a, double b, double c, double d)
        {
            double two_PI = 2 * System.Math.PI;
            double four_PI = 4 * System.Math.PI;

            // Normalize coefficients.
            double denom = a;
            a = b / denom;
            b = c / denom;
            c = d / denom;

            // Commence solution.
            double a_over_3 = a / 3;
            double q = (3 * b - a * a) / 9;
            double q_Qube = q * q * q;
            double r = (9 * a * b - 27 * c - 2 * a * a * a) / 54;
            double r_Square = r * r;
            double D = q_Qube + r_Square;

            if (D < 0)
            {
                // Three unequal real roots.
                double theta = System.Math.Acos(r / System.Math.Sqrt(-q_Qube));
                double q_Sqrt = System.Math.Sqrt(-q);
                double x = 2f * q_Sqrt * System.Math.Cos(theta / 3f) - a_over_3;
                double y = 2f * q_Sqrt * System.Math.Cos((theta + two_PI) / 3f) - a_over_3;
                double z = 2f * q_Sqrt * System.Math.Cos((theta + four_PI) / 3f) - a_over_3;
                return [x, y, z];
            }
            else if (D > 0)
            {
                // One real root.
                double d_Sqrt = System.Math.Sqrt(D);
                double s = CubeRoot(r + d_Sqrt);
                double t = CubeRoot(r - d_Sqrt);
                double x = (s + t) - a_over_3;
                return [x];
            }
            else
            {
                // Three real roots, at least two equal.
                double r_CubeRoot = CubeRoot(r);
                double x = 2 * r_CubeRoot - a_over_3;
                double y = r_CubeRoot - a_over_3;
                double z = y;
                return [x, y, z];
            }
        }

        //Solve ax^3 + bx^2 + cx + d = 0 following
        //Source: http://www.code-kings.com/2013/11/cubic-equation-roots-in-csharp-code.html
        /// <summary>
        /// Solves a cubic equation ax³ + bx² + cx + d = 0, specifically returning results only when three real roots exist.
        /// </summary>
        /// <param name="a">The coefficient of the x³ term.</param>
        /// <param name="b">The coefficient of the x² term.</param>
        /// <param name="c">The coefficient of the x term.</param>
        /// <param name="d">The constant term.</param>
        /// <param name="tolerance">The tolerance value used for rounding and comparison operations, defaulting to <see cref="Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>An array containing the three real roots if they exist; otherwise, null.</returns>
        public static double[]? RealCubicRoots_ThreeRootsOnly(double a, double b, double c, double d, double tolerance = Core.Constants.Tolerance.Distance)
        {
            // Direct multiplication instead of System.Math.Pow for small integer powers
            // (Pow routes through exp/log); reuse of repeated subexpressions.
            double a2 = a * a;
            double a3 = a2 * a;
            double b2 = b * b;
            double b3 = b2 * b;

            double f = ((3 * c / a) - (b2 / a2)) / 3;
            double g = (((2 * b3) / a3) - ((9 * b * c) / a2) + (27 * d / a)) / 27;
            double g2_Quarter = g * g * 0.25;
            double h = Core.Query.Round(g2_Quarter + ((f * f * f) / 27), tolerance);

            if (h <= 0)
            {
                double i = System.Math.Sqrt(g2_Quarter - h);
                double j = CubeRoot(i);
                double k = System.Math.Acos(-g / (2 * i));
                double l = -j;
                double m = System.Math.Cos(k / 3);
                double n = System.Math.Sqrt(3) * System.Math.Sin(k / 3);
                double p = -b / (3 * a);
                double x = (2 * j * m) + p;
                double y = l * (m + n) + p;
                double z = l * (m - n) + p;
                return [x, y, z];
            }
            else
            {
                return null;
            }
        }
    }
}