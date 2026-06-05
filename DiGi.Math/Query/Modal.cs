using System.Collections.Generic;
using System.Linq;

namespace DiGi.Math
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the modal value (the most frequent element) from the specified collection.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="values">The collection of values to analyze.</param>
        /// <returns>The most frequently occurring element of type <typeparam ref="T"/>, or the default value if the collection is null or empty.</returns>
        public static T? Modal<T>(this IEnumerable<T>? values)
        {
            if (values == null)
            {
                return default;
            }

            return values.GroupBy(i => i)  //Grouping same items
                        .OrderByDescending(g => g.Count()) //now getting frequency of a value
                        .Select(g => g.Key) //selecting key of the group
                        .FirstOrDefault();
        }
    }
}