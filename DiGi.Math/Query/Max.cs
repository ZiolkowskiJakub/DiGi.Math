using System.Linq;

namespace DiGi.Math
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the maximum value from a collection of values.
        /// </summary>
        /// <typeparam name="T">The type of the values being compared.</typeparam>
        /// <param name="values">A variable number of values to evaluate.</param>
        /// <returns>The maximum value found in the provided array, or the default value of <typeparamref name="T"/> if the input is null.</returns>
        public static T? Max<T>(params T[]? values)
        {
            if (values == null)
            {
                return default;
            }

            return values.Max();
        }
    }
}