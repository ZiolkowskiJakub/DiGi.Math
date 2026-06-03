using System.Collections.Generic;
using System.Linq;

namespace DiGi.Math
{
    public static partial class Create
    {
        public static partial class Matrix
        {
            /// <summary>
            /// Creates an identity matrix of the specified size.
            /// </summary>
            /// <param name="count">The number of rows and columns for the square identity matrix.</param>
            /// <returns>An identity matrix of size count x count.</returns>
            public static Classes.Matrix Identity(int count = 3)
            {
                Classes.Matrix matrix = new(new double[count, count]);
                for (int i = 0; i < count; i++)
                {
                    matrix[i, i] = 1;
                }

                return matrix;
            }

            /// <summary>
            /// Creates a diagonal scale matrix from the given values.
            /// </summary>
            /// <param name="values">The diagonal values of the scale matrix.</param>
            /// <returns>A scale matrix with dimensions (count+1) x (count+1), or null if values are null.</returns>
            public static Classes.Matrix? Scale(IEnumerable<double>? values)
            {
                if (values == null)
                {
                    return null;
                }

                int count = values.Count();

                Classes.Matrix matrix = Identity(count + 1);

                for (int i = 0; i < count; i++)
                {
                    matrix[i, i] = values.ElementAt(i);
                }

                return matrix;
            }

            /// <summary>
            /// Creates a diagonal scale matrix with the specified factor.
            /// </summary>
            /// <param name="count">The number of diagonal elements to set.</param>
            /// <param name="factor">The scaling factor for each diagonal element.</param>
            /// <returns>A scale matrix with dimensions (count+1) x (count+1).</returns>
            public static Classes.Matrix Scale(int count, double factor)
            {
                Classes.Matrix matrix = Identity(count + 1);

                for (int i = 0; i < count; i++)
                {
                    matrix[i, i] = factor;
                }

                return matrix;
            }

            /// <summary>
            /// Creates a matrix of the specified size and initializes all values to double.MinValue.
            /// </summary>
            /// <param name="rowCount">The number of rows in the matrix.</param>
            /// <param name="columnCount">The number of columns in the matrix.</param>
            /// <returns>A matrix filled with double.MinValue.</returns>
            public static Classes.Matrix Unset(int rowCount, int columnCount)
            {
                Classes.Matrix result = new(rowCount, columnCount);
                result.SetValues(double.MinValue);

                return result;
            }
        }
    }
}