namespace DiGi.Math
{
    public static partial class Create
    {
        public static partial class Matrix4D
        {
            /// <summary>
            /// Creates a Matrix4D from an existing Matrix object.
            /// </summary>
            /// <param name="matrix">The matrix to convert from.</param>
            /// <returns>A Matrix4D object, or null if the provided matrix is not 4x4.</returns>
            public static Classes.Matrix4D? ByMatrix(Classes.Matrix? matrix)
            {
                if (matrix == null)
                {
                    return null;
                }

                if (matrix.RowCount() != 4 || matrix.ColumnCount() != 4)
                {
                    return null;
                }

                Classes.Matrix4D result = new();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        result[i, j] = matrix[i, j];
                    }
                }

                return result;
            }

            /// <summary>
            /// Creates a Matrix4D from a 2D array of values.
            /// </summary>
            /// <param name="values">The values to use for the matrix.</param>
            /// <returns>A Matrix4D object, or null if the provided values are not 4x4.</returns>
            public static Classes.Matrix4D? ByValues(double[,]? values)
            {
                if (values == null)
                {
                    return null;
                }

                if (values.GetLength(0) != 4 || values.GetLength(1) != 4)
                {
                    return null;
                }

                Classes.Matrix4D result = new();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        result[i, j] = values[i, j];
                    }
                }
                return result;
            }

            /// <summary>
            /// Creates a 4x4 identity matrix.
            /// </summary>
            /// <returns>A Matrix4D representing the identity matrix.</returns>
            public static Classes.Matrix4D Identity()
            {
                Classes.Matrix4D matrix4D = new();
                for (int i = 0; i < 4; i++)
                {
                    matrix4D[i, i] = 1;
                }

                return matrix4D;
            }

            /// <summary>
            /// Creates an unset (zero) 4x4 matrix.
            /// </summary>
            /// <returns>A Matrix4D representing an unset matrix.</returns>
            public static Classes.Matrix4D Unset()
            {
                return ByMatrix(Matrix.Unset(4, 4))!;
            }
        }
    }
}