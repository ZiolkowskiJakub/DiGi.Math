namespace DiGi.Math
{
    public static partial class Query
    {
        // Hyperbolic Cosine
        /// <summary>
        /// Calculates the hyperbolic cosine of a specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The hyperbolic cosine of the specified angle.</returns>
        public static double Cosh(double angle)
        {
            return (System.Math.Exp(angle) + System.Math.Exp(-angle)) / 2;
        }
    }
}