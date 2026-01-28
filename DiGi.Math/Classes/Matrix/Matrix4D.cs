using DiGi.Core.Interfaces;
using DiGi.Math.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Math.Classes
{
    public class Matrix4D : Matrix, ISquareMatrix
    {
        public Matrix4D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Matrix4D(Matrix4D? matrix4D)
            : base(matrix4D)
        {
        }

        public Matrix4D()
            : base(4, 4)
        {
        }

        public static explicit operator Matrix4D?(double[,]? values)
        {
            if (values == null)
            {
                return null;
            }

            return Create.Matrix4D.ByValues(values);
        }

        public static Matrix4D? operator -(Matrix4D? matrix4D_1, Matrix4D? matrix4D_2)
        {
            if (matrix4D_1 == null || matrix4D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix4D_1) + ((Matrix)matrix4D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix4D.ByMatrix(matrix);
        }

        public static Matrix4D? operator -(Matrix4D? matrix4D, double value)
        {
            if (matrix4D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix4D + (-value);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix4D.ByMatrix(matrix);
        }

        public static Matrix4D? operator *(Matrix4D? matrix4D_1, Matrix4D? matrix4D_2)
        {
            if (matrix4D_1 == null || matrix4D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix4D_1) * ((Matrix)matrix4D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix4D.ByMatrix(matrix);
        }

        public static Matrix4D? operator *(Matrix4D? matrix4D, double value)
        {
            if (matrix4D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix4D * value;
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix4D.ByMatrix(matrix);
        }

        public static Matrix4D? operator +(Matrix4D? matrix4D, double value)
        {
            if (matrix4D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix4D + value;
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix4D.ByMatrix(matrix);
        }

        public static Matrix4D? operator +(Matrix4D? matrix4D_1, Matrix4D? matrix4D_2)
        {
            if (matrix4D_1 == null || matrix4D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix4D_1) + ((Matrix)matrix4D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix4D.ByMatrix(matrix);
        }

        public override ISerializableObject? Clone()
        {
            return new Matrix4D(this);
        }
    }
}