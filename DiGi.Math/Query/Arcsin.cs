namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Sine
        /// <summary>
        /// Calculates the inverse sine (arcsine) of a specified value.
        /// </summary>
        /// <param name="angle">The value for which to calculate the inverse sine. This value must be between -1 and 1 inclusive.</param>
        /// <returns>The angle in radians whose sine is the specified value.</returns>
        public static double Arcsin(double angle)
        {
            return System.Math.Atan(angle / System.Math.Sqrt(-angle * angle + 1));
        }
    }
}