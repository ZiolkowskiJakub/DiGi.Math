using System.Collections.Generic;

namespace DiGi.Math
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the median value of a collection of double-precision floating-point numbers.
        /// </summary>
        /// <param name="values">The collection of double-precision floating-point numbers to evaluate.</param>
        /// <returns>The median value if the collection is not null or empty; otherwise, <see cref="double.NaN"/>.</returns>
        public static double Median(this IEnumerable<double>? values)
        {
            if (values == null)
            {
                return double.NaN;
            }

            // Materialize and sort a private copy once: the median is an order statistic, so the
            // input must be ordered, and a single O(n log n) sort beats repeated O(n) ElementAt calls.
            double[] sorted = [.. values];
            int count = sorted.Length;
            if (count == 0)
            {
                return double.NaN;
            }

            System.Array.Sort(sorted);

            if (count == 1)
            {
                return sorted[0];
            }

            int half = count / 2;
            if (count % 2 == 0)
            {
                return (sorted[half] + sorted[half - 1]) / 2;
            }
            else
            {
                return sorted[half];
            }
        }
    }
}