namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Cosine
        //https://mathworld.wolfram.com/InverseCosine.html
        /// <summary>
        /// Calculates the inverse cosine (arccosine) of a specified value.
        /// </summary>
        /// <param name="angle">The value whose inverse cosine is to be computed. This value should be between -1 and 1.</param>
        /// <returns>The arccosine of the specified value, expressed in radians.</returns>
        public static double Arccos(double angle)
        {
            return System.Math.Atan(-angle / System.Math.Sqrt(-angle * angle + 1)) + 2 * System.Math.Atan(1);
        }
    }
}