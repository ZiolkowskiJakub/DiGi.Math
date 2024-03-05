using System.Linq;

namespace DiGi.Math
{
    public static partial class Query
    {
        public static T Min<T>(params T[] values)
        {
            if (values == null)
                return default;

            return values.ToList().Min();
        }
    }
}