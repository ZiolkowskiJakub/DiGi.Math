namespace DiGi.Math
{
    public static partial class Query
    {
        /// <summary>
        /// Returns neigbour indices in values array for given value. Values have to be sorted.
        /// </summary>
        /// <param name="values">Values array</param>
        /// <param name="value">Value</param>
        /// <param name="lowerIndex">Lower Index</param>
        /// <param name="upperIndex">Upper Index</param>
        public static void NeigbourIndices(double[]? values, double value, out int lowerIndex, out int upperIndex)
        {
            lowerIndex = -1;
            upperIndex = -1;

            if (values == null || values.Length == 0 || double.IsNaN(value))
            {
                return;
            }

            if (value <= values[0])
            {
                lowerIndex = 0;
                upperIndex = 0;
                return;
            }

            int lastIndex = values.Length - 1;
            if (value >= values[lastIndex])
            {
                lowerIndex = lastIndex;
                upperIndex = lastIndex;
                return;
            }

            // Binary search for the first index whose value is strictly greater than 'value'
            // (the upper neighbour). Values must be sorted ascending, as documented above.
            // This replaces the previous O(n) linear scan with an O(log n) search while
            // preserving the exact bracketing semantics, including for repeated values.
            int low = 0;
            int high = values.Length;
            while (low < high)
            {
                int mid = low + ((high - low) / 2);
                if (values[mid] > value)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            upperIndex = low;
            lowerIndex = low - 1;
        }
    }
}