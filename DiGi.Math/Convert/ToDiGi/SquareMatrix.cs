using DiGi.Math.Classes;
using DiGi.Math.Interfaces;

namespace DiGi.Math
{
    public static partial class Convert
    {
        public static ISquareMatrix ToDiGi_SquareMatrix(this Matrix matrix)
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
