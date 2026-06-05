namespace DiGi.Math
{
    public static partial class Query
    {
        // Cotangent
        //https://mathworld.wolfram.com/Cotangent.html
        /// <summary>
        /// Calculates the cotangent of the specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The cotangent of the angle.</returns>
        public static double Cotan(double angle)
        {
            return 1 / System.Math.Tan(angle);
        }
    }
}