namespace DiGi.Math
{
    public static partial class Query
    {
        // Hyperbolic Sine
        //https://mathworld.wolfram.com/HyperbolicSine.html
        /// <summary>
        /// Calculates the hyperbolic sine of the specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians for which to calculate the hyperbolic sine.</param>
        /// <returns>The hyperbolic sine of the specified angle.</returns>
        public static double Sinh(double angle)
        {
            return (System.Math.Exp(angle) - System.Math.Exp(-angle)) / 2;
        }
    }
}