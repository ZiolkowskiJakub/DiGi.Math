namespace DiGi.Math
{
    public static partial class Query
    {
        // Hyperbolic Tangent
        //https://mathworld.wolfram.com/HyperbolicTangent.html
        /// <summary>
        /// Calculates the hyperbolic tangent of the specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians for which to calculate the hyperbolic tangent.</param>
        /// <returns>The hyperbolic tangent of the specified angle.</returns>
        public static double Tanh(double angle)
        {
            return (System.Math.Exp(angle) - System.Math.Exp(-angle)) / (System.Math.Exp(angle) + System.Math.Exp(-angle));
        }
    }
}