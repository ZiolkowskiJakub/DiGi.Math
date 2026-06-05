namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Hyperbolic Tangent (Latin: Area tangens hyperbolicus)
        //https://en.wikipedia.org/wiki/Inverse_hyperbolic_functions#asinh
        //https://mathworld.wolfram.com/InverseHyperbolicTangent.html
        /// <summary>
        /// Calculates the inverse hyperbolic tangent of a specified number.
        /// </summary>
        /// <param name="x">The number for which to calculate the inverse hyperbolic tangent.</param>
        /// <returns>The inverse hyperbolic tangent of <paramref name="x"/>.</returns>
        public static double Artanh(double x)
        {
            return System.Math.Log((1 + x) / (1 - x)) / 2;
        }
    }
}