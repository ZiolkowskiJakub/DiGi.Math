using System.Collections.Generic;
using System.Linq;

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

            int count = values.Count();
            if (count == 0)
            {
                return double.NaN;
            }

            if (count == 1)
            {
                return values.First();
            }

            int half = count / 2;
            if (count % 2 == 0)
            {
                return (values.ElementAt(half) + values.ElementAt(half - 1)) / 2;
            }
            else
            {
                return values.ElementAt(half);
            }
        }
    }
}