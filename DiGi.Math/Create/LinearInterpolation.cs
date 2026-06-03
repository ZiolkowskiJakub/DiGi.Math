using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a LinearInterpolation object from a file.
        /// </summary>
        /// <param name="path">The path to the data file.</param>
        /// <param name="separator">The separator used in the data file.</param>
        /// <returns>A LinearInterpolation object, or null if the file cannot be read.</returns>
        public static LinearInterpolation? LinearInterpolation(string? path, string separator = "\t")
        {
            double[,]? data = Core.Create.Array(path, separator, true, double.NaN);
            if (data == null)
            {
                return null;
            }

            return new LinearInterpolation(data);
        }
    }
}