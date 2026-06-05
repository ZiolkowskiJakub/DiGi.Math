namespace DiGi.Math
{
    public static partial class Query
    {
        // Hyperbolic Secant
        //https://mathworld.wolfram.com/HyperbolicSecant.html
        /// <summary>
        /// Calculates the hyperbolic secant of the specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The hyperbolic secant of the angle.</returns>
        public static double Sech(double angle)
        {
            return 2 / (System.Math.Exp(angle) + System.Math.Exp(-angle));
        }
    }
}