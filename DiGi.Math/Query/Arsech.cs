namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Hyperbolic Secant (Latin: Area secans hyperbolicus)
        //https://en.wikipedia.org/wiki/Inverse_hyperbolic_functions#asinh
        //https://mathworld.wolfram.com/InverseHyperbolicSecant.html
        /// <summary>
        /// Calculates the inverse hyperbolic secant (arsech) of a specified value.
        /// </summary>
        /// <param name="x">The double-precision floating-point number for which to calculate the inverse hyperbolic secant.</param>
        /// <returns>The inverse hyperbolic secant of <paramref name="x"/>.</returns>
        public static double Arsech(double x)
        {
            return System.Math.Log((System.Math.Sqrt(-x * x + 1) + 1) / x);
        }
    }
}