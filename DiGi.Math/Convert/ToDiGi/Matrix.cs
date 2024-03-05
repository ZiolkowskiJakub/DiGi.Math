using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Convert
    {
        public static Matrix ToDiGi(this MathNet.Numerics.LinearAlgebra.Matrix<double> matrix)
        {
            if (matrix == null)
            {
                return null;
            }

            return new Matrix(matrix.ToArray());
        }
    }
}
