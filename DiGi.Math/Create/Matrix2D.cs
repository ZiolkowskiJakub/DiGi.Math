namespace DiGi.Math
{
    public static partial class Create
    {
        public static partial class Matrix2D
        {
            public static Classes.Matrix2D ByMatrix(Classes.Matrix matrix)
            {
                if (matrix == null)
                {
                    return null;
                }

                if (matrix.RowCount() != 2 || matrix.ColumnCount() != 2)
                {
                    return null;
                }

                Classes.Matrix2D result = new Classes.Matrix2D();
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        result[i, j] = matrix[i, j];
                    }
                }

                return result;
            }

            public static Classes.Matrix2D ByValues(double[,] values)
            {
                if (values == null)
                {
                    return null;
                }

                if (values.GetLength(0) != 2 || values.GetLength(1) != 2)
                {
                    return null;
                }

                Classes.Matrix2D result = new Classes.Matrix2D();
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        result[i, j] = values[i, j];
                    }
                }

                return result;
            }

            public static Classes.Matrix2D Identity()
            {
                Classes.Matrix2D matrix2D = new Classes.Matrix2D();
                for (int i = 0; i < 2; i++)
                {
                    matrix2D[i, i] = 1;
                }

                return matrix2D;
            }
        }



    }
}
