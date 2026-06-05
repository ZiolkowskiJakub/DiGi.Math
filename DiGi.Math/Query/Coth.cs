namespace DiGi.Math
{
    public static partial class Query
    {
        // Hyperbolic Cotangent
        //https://mathworld.wolfram.com/HyperbolicCotangent.html
        /// <summary>
        /// Calculates the hyperbolic cotangent of the specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians for which the hyperbolic cotangent is calculated.</param>
        /// <returns>The hyperbolic cotangent of the specified angle.</returns>
        public static double Coth(double angle)
        {
            return (System.Math.Exp(angle) + System.Math.Exp(-angle)) / (System.Math.Exp(angle) - System.Math.Exp(-angle));
        }
    }
}