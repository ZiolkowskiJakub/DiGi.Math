using System.Linq;

namespace DiGi.Math
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the minimum value from a collection of values.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="values">An optional array of values to evaluate.</param>
        /// <returns>The minimum value found in the array, or the default value of <typeparamref name="T"/> if the array is null.</returns>
        public static T? Min<T>(params T[]? values)
        {
            if (values == null)
            {
                return default;
            }

            return values.ToList().Min();
        }
    }
}