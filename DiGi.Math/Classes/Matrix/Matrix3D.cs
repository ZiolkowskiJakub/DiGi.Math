using DiGi.Math.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Math.Classes
{
    public class Matrix3D : Matrix, ISquareMatrix
    {
        public Matrix3D(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public Matrix3D(Matrix3D matrix3D)
            : base(matrix3D)
        {

        }

        public Matrix3D()
            : base(3, 3)
        {

        }

        public override Matrix Clone()
        {
            return new Matrix3D(this);
        }

        public static Matrix3D operator *(Matrix3D matrix3D_1, Matrix3D matrix3D_2)
        {
            if (matrix3D_1 == null || matrix3D_2 == null)
            {
                return null;
            }

            Matrix matrix = ((Matrix)matrix3D_1) * ((Matrix)matrix3D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        public static Matrix3D operator *(Matrix3D matrix3D, double value)
        {
            if (matrix3D == null)
            {
                return null;
            }

            Matrix matrix = (Matrix)matrix3D * value;
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        public static Matrix3D operator +(Matrix3D matrix3D, double value)
        {
            if (matrix3D == null)
            {
                return null;
            }

            Matrix matrix = (Matrix)matrix3D + value;
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        public static Matrix3D operator +(Matrix3D matrix3D_1, Matrix3D matrix3D_2)
        {
            if (matrix3D_1 == null || matrix3D_2 == null)
            {
                return null;
            }

            Matrix matrix = ((Matrix)matrix3D_1) + ((Matrix)matrix3D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        public static Matrix3D operator -(Matrix3D matrix3D_1, Matrix3D matrix3D_2)
        {
            if (matrix3D_1 == null || matrix3D_2 == null)
            {
                return null;
            }

            Matrix matrix = ((Matrix)matrix3D_1) + ((Matrix)matrix3D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        public static Matrix3D operator -(Matrix3D matrix3D, double value)
        {
            if (matrix3D == null)
            {
                return null;
            }

            Matrix matrix = (Matrix)matrix3D + (-value);
            if (matrix == null)
            {
                return null;
            }


            return Create.Matrix3D.ByMatrix(matrix);
        }


        public static explicit operator Matrix3D(double[,] values)
        {
            return Create.Matrix3D.ByValues(values);
        }
    }
}
