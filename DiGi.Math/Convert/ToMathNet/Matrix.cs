using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Convert
    {
        public static MathNet.Numerics.LinearAlgebra.Matrix<double> ToMathNet(this Matrix matrix)
        {
            if (matrix == null)
                return null;

            return MathNet.Numerics.LinearAlgebra.CreateMatrix.DenseOfArray(matrix.ToArray());
        }
    }
}
