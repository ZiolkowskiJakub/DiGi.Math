using DiGi.Math.Classes;
using DiGi.Math.Interfaces;

namespace DiGi.Math
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Matrix to an ISquareMatrix if it is square and its size is 2, 3, or 4.
        /// </summary>
        /// <param name="matrix">The matrix to convert.</param>
        /// <returns>An ISquareMatrix object, or null if the matrix is not square or has an unsupported size.</returns>
        public static ISquareMatrix? ToDiGi_SquareMatrix(this Matrix? matrix)
        {
            if (matrix == null)
            {
                return null;
            }

            if (matrix.IsSquare())
            {
                int count = matrix.RowCount();

                if (count == 2)
                {
                    return Create.Matrix2D.ByMatrix(matrix);
                }

                if (count == 3)
                {
                    return Create.Matrix3D.ByMatrix(matrix);
                }

                if (count == 4)
                {
                    return Create.Matrix4D.ByMatrix(matrix);
                }
            }

            return null;
        }
    }
}