using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Matrix to a MathNet.Numerics.LinearAlgebra.Matrix object.
        /// </summary>
        /// <param name="matrix">The matrix to convert.</param>
        /// <returns>A MathNet.Numerics.LinearAlgebra.Matrix object, or null if the input is null.</returns>
        public static MathNet.Numerics.LinearAlgebra.Matrix<double>? ToMathNet(this Matrix? matrix)
        {
            if (matrix == null)
            {
                return null;
            }

            return MathNet.Numerics.LinearAlgebra.CreateMatrix.DenseOfArray(matrix.ToArray());
        }
    }
}