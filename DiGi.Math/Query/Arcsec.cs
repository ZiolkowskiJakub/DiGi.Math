namespace DiGi.Math
{
    public static partial class Query
    {
        // Inverse Secant
        //https://mathworld.wolfram.com/InverseSecant.html
        /// <summary>
        /// Calculates the inverse secant (arcsecant) of a specified number.
        /// </summary>
        /// <param name="x">The number for which to calculate the inverse secant.</param>
        /// <returns>The inverse secant of <paramref name="x"/> expressed in radians.</returns>
        public static double Arcsec(double x)
        {
            return 2 * System.Math.Atan(1) - System.Math.Atan(System.Math.Sign(x) / System.Math.Sqrt(x * x - 1));
        }
    }
}