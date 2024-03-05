using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Create
    {
        public static LinearInterpolation LinearInterpolation(string path, string separator = "\t")
        {
            double[,] data = Core.Create.Array(path, separator, true, double.NaN);
            if (data == null)
            {
                return null;
            }

            return new LinearInterpolation(data);
        }
    }
}
