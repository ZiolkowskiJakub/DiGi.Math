namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Cotangent
        //https://mathworld.wolfram.com/InverseCotangent.html
        /// <summary>
        /// Calculates the inverse cotangent (arccotangent) of a specified value.
        /// </summary>
        /// <param name="angle">The numeric value for which to calculate the inverse cotangent.</param>
        /// <returns>The inverse cotangent of the specified value, expressed in radians.</returns>
        public static double Arccotan(double angle)
        {
            return 2 * System.Math.Atan(1) - System.Math.Atan(angle);
        }
    }
}