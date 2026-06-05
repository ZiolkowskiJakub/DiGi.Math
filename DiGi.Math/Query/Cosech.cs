namespace DiGi.Math
{
    public static partial class Query
    {
        // Hyperbolic Cosecant
        //https://mathworld.wolfram.com/HyperbolicCosecant.html
        /// <summary>
        /// Calculates the hyperbolic cosecant of the specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The hyperbolic cosecant of the angle.</returns>
        public static double Cosech(double angle)
        {
            return 2 / (System.Math.Exp(angle) - System.Math.Exp(-angle));
        }
    }
}