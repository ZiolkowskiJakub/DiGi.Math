namespace DiGi.Math
{
    public static partial class Create
    {
        public static partial class Matrix2D
        {
            /// <summary>
            /// Creates a Matrix2D from an existing Matrix object.
            /// </summary>
            /// <param name="matrix">The matrix to convert from.</param>
            /// <returns>A Matrix2D object, or null if the provided matrix is not 2x2.</returns>
            public static Classes.Matrix2D? ByMatrix(Classes.Matrix? matrix)
            {
                if (matrix == null)
                {
                    return null;
                }

                if (matrix.RowCount() != 2 || matrix.ColumnCount() != 2)
                {
                    return null;
                }

                Classes.Matrix2D result = new();
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        result[i, j] = matrix[i, j];
                    }
                }

                return result;
            }

            /// <summary>
            /// Creates a Matrix2D from a 2D array of values.
            /// </summary>
            /// <param name="values">The values to use for the matrix.</param>
            /// <returns>A Matrix2D object, or null if the provided values are not 2x2.</returns>
            public static Classes.Matrix2D? ByValues(double[,]? values)
            {
                if (values == null)
                {
                    return null;
                }

                if (values.GetLength(0) != 2 || values.GetLength(1) != 2)
                {
                    return null;
                }

                Classes.Matrix2D result = new();
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        result[i, j] = values[i, j];
                    }
                }

                return result;
            }

            /// <summary>
            /// Creates a 2x2 identity matrix.
            /// </summary>
            /// <returns>A Matrix2D representing the identity matrix.</returns>
            public static Classes.Matrix2D Identity()
            {
                Classes.Matrix2D matrix2D = new();
                for (int i = 0; i < 2; i++)
                {
                    matrix2D[i, i] = 1;
                }

                return matrix2D;
            }
        }
    }
}