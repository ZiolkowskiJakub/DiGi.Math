namespace DiGi.Math
{
    public static partial class Query
    {
        private const double oneThird = 1 / 3;

        // Cube Root
        //https://wiki.unity3d.com/index.php/3d_Math_functions
        /// <summary>
        /// Calculates the cube root of a specified double-precision floating-point number.
        /// </summary>
        /// <param name="value">The double-precision floating-point number to calculate the cube root of.</param>
        /// <returns>The cube root of the specified value.</returns>
        public static double CubeRoot(double value)
        {
            if (value < 0)
                return -System.Math.Pow(-value, oneThird);

            return System.Math.Pow(value, oneThird);
        }
    }
}