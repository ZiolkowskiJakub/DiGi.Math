using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a MathNet.Numerics.LinearAlgebra.Matrix to a Matrix object.
        /// </summary>
        /// <param name="matrix">The MathNet matrix to convert.</param>
        /// <returns>A Matrix object, or null if the input is null.</returns>
        public static Matrix? ToDiGi(this MathNet.Numerics.LinearAlgebra.Matrix<double>? matrix)
        {
            if (matrix == null)
            {
                return null;
            }

            return new Matrix(matrix.ToArray());
        }
    }
}