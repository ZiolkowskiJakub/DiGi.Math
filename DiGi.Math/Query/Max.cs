using System.Linq;

namespace DiGi.Math
{
    public static partial class Query
    {
        public static T Max<T>(params T[] values)
        {
            if (values == null)
                return default;

            return values.ToList().Max();
        }
    }
}