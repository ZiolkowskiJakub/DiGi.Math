namespace DiGi.Math
{
    public static partial class Create
    {
        public static partial class Matrix4D
        {
            public static Classes.Matrix4D ByMatrix(Classes.Matrix matrix)
            {
                if (matrix == null)
                {
                    return null;
                }

                if (matrix.RowCount() != 4 || matrix.ColumnCount() != 4)
                {
                    return null;
                }

                Classes.Matrix4D result = new Classes.Matrix4D();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        result[i, j] = matrix[i, j];
                    }
                }

                return result;
            }

            public static Classes.Matrix4D ByValues(double[,] values)
            {
                if (values == null)
                {
                    return null;
                }

                if (values.GetLength(0) != 4 || values.GetLength(1) != 4)
                {
                    return null;
                }

                Classes.Matrix4D result = new Classes.Matrix4D();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        result[i, j] = values[i, j];
                    }
                }
                return result;
            }

            public static Classes.Matrix4D Identity()
            {
                Classes.Matrix4D matrix4D = new Classes.Matrix4D();
                for (int i = 0; i < 4; i++)
                {
                    matrix4D[i, i] = 1;
                }

                return matrix4D;
            }

            public static Classes.Matrix4D Unset()
            {
                return ByMatrix(Matrix.Unset(4, 4));
            }
        }


    }
}
