namespace DiGi.Math
{
    public static partial class Query
    {
        // Secant
        //https://mathworld.wolfram.com/Secant.html
        /// <summary>
        /// Calculates the secant of a specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The secant of the specified angle.</returns>
        public static double Sec(double angle)
        {
            return 1 / System.Math.Cos(angle);
        }
    }
}