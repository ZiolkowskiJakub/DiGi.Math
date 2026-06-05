namespace DiGi.Math
{
    public static partial class Query
    {
        // Cosecant
        //https://mathworld.wolfram.com/Cosecant.html
        /// <summary>
        /// Calculates the cosecant of a specified angle.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The cosecant of the specified angle.</returns>
        public static double Cosec(double angle)
        {
            return 1 / System.Math.Sin(angle);
        }
    }
}