using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a BilinearInterpolation object from a file.
        /// </summary>
        /// <param name="path">The path to the data file.</param>
        /// <param name="separator">The separator used in the data file.</param>
        /// <returns>A BilinearInterpolation object, or null if the file cannot be read.</returns>
        public static BilinearInterpolation? BilinearInterpolation(string? path, string separator = "\t")
        {
            double[,]? data = Core.Create.Array(path, separator, true, double.NaN);
            if (data == null)
            {
                return null;
            }

            return new BilinearInterpolation(data);
        }
    }
}