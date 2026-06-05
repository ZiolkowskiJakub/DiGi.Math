namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Hyperbolic Sine (Latin: Area sinus hyperbolicus)
        //https://en.wikipedia.org/wiki/Inverse_hyperbolic_functions#asinh
        //https://mathworld.wolfram.com/InverseHyperbolicSine.html
        /// <summary>
        /// Calculates the inverse hyperbolic sine (asinh) of a specified number.
        /// </summary>
        /// <param name="x">The numeric value for which to compute the inverse hyperbolic sine.</param>
        /// <returns>The inverse hyperbolic sine of <paramref name="x"/>.</returns>
        public static double Arsinh(double x)
        {
            return System.Math.Log(x + System.Math.Sqrt(x * x + 1));
        }
    }
}