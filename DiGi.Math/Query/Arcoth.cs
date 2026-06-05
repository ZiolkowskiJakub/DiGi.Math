namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Hyperbolic Cotangent  (Latin: Area cotangens hyperbolicus)
        //https://en.wikipedia.org/wiki/Inverse_hyperbolic_functions#asinh
        //https://mathworld.wolfram.com/InverseHyperbolicCotangent.html
        /// <summary>
        /// Calculates the inverse hyperbolic cotangent of a specified number.
        /// </summary>
        /// <param name="x">The number for which to calculate the inverse hyperbolic cotangent.</param>
        /// <returns>The inverse hyperbolic cotangent of <paramref name="x"/>.</returns>
        public static double Arcoth(double x)
        {
            return System.Math.Log((x + 1) / (x - 1)) / 2;
        }
    }
}