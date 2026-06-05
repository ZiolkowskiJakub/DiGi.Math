namespace DiGi.Math
{
    public static partial class Query
    {
        // Logarithm to base N
        //https://mathworld.wolfram.com/Logarithm.html
        /// <summary>
        /// Calculates the logarithm of a specified number to a specified base.
        /// </summary>
        /// <param name="x">The number to calculate the logarithm for.</param>
        /// <param name="n">The base of the logarithm.</param>
        /// <returns>The logarithm of <paramref name="x"/> to base <paramref name="n"/>.</returns>
        public static double LogN(double x, double n)
        {
            return System.Math.Log(x) / System.Math.Log(n);
        }
    }
}