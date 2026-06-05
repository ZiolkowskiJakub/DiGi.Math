namespace DiGi.Math
{
    public static partial class Query
    {
        /// <summary>
        /// Remaps a value from one numeric range to another.
        /// </summary>
        /// <param name="value">The double-precision floating-point number to remap.</param>
        /// <param name="from_1">The lower bound of the source range.</param>
        /// <param name="to_1">The upper bound of the source range.</param>
        /// <param name="from_2">The lower bound of the target range.</param>
        /// <param name="to_2">The upper bound of the target range.</param>
        /// <returns>The value mapped into the target range, or <paramref name="from_2"/> if the source or target ranges have zero width.</returns>
        public static double Remap(this double value, double from_1, double to_1, double from_2, double to_2)
        {
            if ((to_1 - from_1) * (to_2 - from_2) == 0)
            { return from_2; }
            else
            {
                return ((value - from_1) / (to_1 - from_1) * (to_2 - from_2) + from_2);
            }
        }
    }
}