namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Hyperbolic Cosecant (Latin: Area cosecans hyperbolicus)
        //https://en.wikipedia.org/wiki/Inverse_hyperbolic_functions#asinh
        //https://mathworld.wolfram.com/InverseHyperbolicCosecant.html
        /// <summary>
        /// Calculates the inverse hyperbolic cosecant (csch⁻¹) of a specified number.
        /// </summary>
        /// <param name="x">The double-precision floating-point number for which to calculate the inverse hyperbolic cosecant.</param>
        /// <returns>The inverse hyperbolic cosecant of <paramref name="x"/>.</returns>
        public static double Arcsch(double x)
        {
            return System.Math.Log((System.Math.Sign(x) * System.Math.Sqrt(x * x + 1) + 1) / x);
        }
    }
}