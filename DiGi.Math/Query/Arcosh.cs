namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Hyperbolic Cosine  (Latin: Area cosinus hyperbolicus)
        //https://en.wikipedia.org/wiki/Inverse_hyperbolic_functions#asinh
        //https://mathworld.wolfram.com/InverseHyperbolicCosine.html
        /// <summary>
        /// Calculates the inverse hyperbolic cosine (arccosh) of a specified number.
        /// </summary>
        /// <param name="x">The number for which to calculate the inverse hyperbolic cosine.</param>
        /// <returns>The inverse hyperbolic cosine of <paramref name="x"/>.</returns>
        public static double Arcosh(double x)
        {
            return System.Math.Log(x + System.Math.Sqrt(x * x - 1));
        }
    }
}