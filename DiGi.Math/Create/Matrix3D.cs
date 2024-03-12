namespace DiGi.Math
{
    public static partial class Create
    {
        public static partial class Matrix3D
        {
            public static Classes.Matrix3D ByMatrix(Classes.Matrix matrix)
            {
                if (matrix == null)
                {
                    return null;
                }

                if (matrix.RowCount() != 3 || matrix.ColumnCount() != 3)
                {
                    return null;
                }

                Classes.Matrix3D result = new Classes.Matrix3D();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[i, j] = matrix[i, j];
                    }
                }

                return result;
            }

            public static Classes.Matrix3D ByValues(double[,] values)
            {
                if (values == null)
                {
                    return null;
                }

                if (values.GetLength(0) != 3 || values.GetLength(1) != 3)
                {
                    return null;
                }

                Classes.Matrix3D result = new Classes.Matrix3D();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[i, j] = values[i, j];
                    }
                }

                return result;
            }

            public static Classes.Matrix3D Identity()
            {
                Classes.Matrix3D matrix3D = new Classes.Matrix3D();
                for (int i = 0; i < 3; i++)
                {
                    matrix3D[i, i] = 1;
                }

                return matrix3D;
            }
        }


    }
}
