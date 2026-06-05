namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Cosecant
        //https://mathworld.wolfram.com/InverseCosecant.html
        /// <summary>
        /// Calculates the inverse cosecant (arccosecant) of a specified value.
        /// </summary>
        /// <param name="angle">The value for which to calculate the inverse cosecant.</param>
        /// <returns>The inverse cosecant of the specified value, expressed in radians.</returns>
        public static double Arccosec(double angle)
        {
            return System.Math.Atan(System.Math.Sign(angle) / System.Math.Sqrt(angle * angle - 1));
        }
    }
}