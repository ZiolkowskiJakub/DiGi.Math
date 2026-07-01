using DiGi.Core.Interfaces;
using DiGi.Math.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Math.Classes
{
    /// <summary>
    /// Represents a mathematical matrix with double-precision floating-point elements.
    /// </summary>
    public class Matrix : Core.Classes.SerializableObject, IMatrix
    {
        [JsonInclude, JsonPropertyName("Values")]
        private double[,]? values;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class with the specified number of rows and columns.
        /// </summary>
        /// <param name="rowCount">The number of rows in the matrix.</param>
        /// <param name="columnCount">The number of columns in the matrix.</param>
        public Matrix(int rowCount, int columnCount)
        {
            values = new double[rowCount, columnCount];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class from a 1D array of values.
        /// </summary>
        /// <param name="values">An array of values to be used as the first row of the matrix.</param>
        public Matrix(double[]? values)
        {
            if (values == null)
            {
                this.values = default;
            }
            else
            {
                this.values = new double[1, values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    this.values[0, i] = values[i];
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class from a 2D array of values.
        /// </summary>
        /// <param name="values">The 2D array containing the matrix elements.</param>
        public Matrix(double[,]? values)
        {
            if (values != null)
            {
                int count_Rows = values.GetLength(0);
                int count_Columns = values.GetLength(1);

                this.values = new double[count_Rows, count_Columns];
                for (int i = 0; i < count_Rows; i++)
                {
                    for (int j = 0; j < count_Columns; j++)
                    {
                        this.values[i, j] = values[i, j];
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing matrix data.</param>
        public Matrix(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class by copying another matrix.
        /// </summary>
        /// <param name="matrix">The source matrix to copy.</param>
        public Matrix(Matrix? matrix)
        {
            if (matrix?.values == null)
            {
                return;
            }

            int count_Rows = matrix.values.GetLength(0);
            int count_Columns = matrix.values.GetLength(1);

            values = new double[count_Rows, count_Columns];
            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values[i, j] = matrix.values[i, j];
                }
            }
        }

        /// <summary>
        /// Gets or sets the element at the specified row and column.
        /// </summary>
        /// <param name="row">The zero-based index of the row.</param>
        /// <param name="column">The zero-based index of the column.</param>
        /// <returns>The value of the element at the specified position.</returns>
        [JsonIgnore]
        public double this[int row, int column]
        {
            get
            {
                if (values == null)
                {
                    return double.NaN;
                }

                return values[row, column];
            }
            set
            {
                if (values == null)
                {
                    return;
                }

                values[row, column] = value;
            }
        }

        /// <summary>
        /// Explicitly converts a two-dimensional array of doubles to a <see cref="Matrix"/>.
        /// </summary>
        /// <param name="values">The two-dimensional array of doubles to convert.</param>
        /// <returns>A new <see cref="Matrix"/> instance created from the provided values, or <see langword="null"/> if the input array is null.</returns>
        public static explicit operator Matrix?(double[,]? values)
        {
            if (values == null)
            {
                return null;
            }

            return new Matrix(values);
        }

        /// <summary>
        /// Subtracts the second matrix from the first matrix element-wise.
        /// </summary>
        /// <param name="matrix_1">The first matrix to subtract from.</param>
        /// <param name="matrix_2">The second matrix to be subtracted.</param>
        /// <returns>A new <see cref="Matrix"/> containing the result of the subtraction, or <see langword="null"/> if either input is null or the matrices have different dimensions.</returns>
        public static Matrix? operator -(Matrix? matrix_1, Matrix? matrix_2)
        {
            if (matrix_1?.values == null || matrix_2?.values == null)
            {
                return null;
            }

            if (!matrix_1.SizeEqual(matrix_2))
            {
                return null;
            }

            Matrix result = new(matrix_1);

            if (result.values != null)
            {
                int count_Rows = result.values.GetLength(0);
                int count_Columns = result.values.GetLength(1);

                for (int i = 0; i < count_Rows; i++)
                {
                    for (int j = 0; j < count_Columns; j++)
                    {
                        result.values[i, j] -= matrix_2.values[i, j];
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Subtracts a scalar value from every element of the matrix.
        /// </summary>
        /// <param name="matrix">The matrix to subtract the value from.</param>
        /// <param name="value">The scalar value to be subtracted from each element.</param>
        /// <returns>A new <see cref="Matrix"/> representing the result of the subtraction, or <see langword="null"/> if the input matrix is null.</returns>
        public static Matrix? operator -(Matrix? matrix, double value)
        {
            return matrix + (-value);
        }

        /// <summary>
        /// Multiplies two matrices together using matrix multiplication.
        /// </summary>
        /// <param name="matrix_1">The first matrix to multiply.</param>
        /// <param name="matrix_2">The second matrix to multiply.</param>
        /// <returns>A new <see cref="Matrix"/> representing the product of the two matrices, or <see langword="null"/> if either input is null or if the number of columns in the first matrix does not match the number of rows in the second matrix.</returns>
        public static Matrix? operator *(Matrix? matrix_1, Matrix? matrix_2)
        {
            if (matrix_1?.values == null || matrix_2?.values == null)
            {
                return null;
            }

            // Work directly against the backing arrays so the inner loop avoids the per-element
            // null check and bounds re-validation of the public indexer (an O(n^3) overhead).
            double[,] values_1 = matrix_1.values;
            double[,] values_2 = matrix_2.values;

            int columnCount_1 = values_1.GetLength(1);
            if (columnCount_1 != values_2.GetLength(0))
            {
                return null;
            }

            int rowCount_1 = values_1.GetLength(0);
            int columnCount_2 = values_2.GetLength(1);

            Matrix result = new(rowCount_1, columnCount_2);
            double[,]? values_Result = result.values;
            if (values_Result == null)
            {
                return result;
            }

            for (int i = 0; i < rowCount_1; i++)
            {
                for (int j = 0; j < columnCount_2; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < columnCount_1; k++)
                    {
                        sum += values_1[i, k] * values_2[k, j];
                    }

                    values_Result[i, j] = sum;
                }
            }

            return result;
        }

        /// <summary>
        /// Multiplies every element of the matrix by a scalar value.
        /// </summary>
        /// <param name="matrix">The matrix to be multiplied.</param>
        /// <param name="value">The scalar value to multiply each element by.</param>
        /// <returns>A new <see cref="Matrix"/> containing the result of the multiplication, or <see langword="null"/> if the input matrix is null.</returns>
        public static Matrix? operator *(Matrix? matrix, double value)
        {
            if (matrix?.values == null)
            {
                return null;
            }

            int count_Rows = matrix.values.GetLength(0);
            int count_Columns = matrix.values.GetLength(1);

            double[,] values_Temp = new double[count_Rows, count_Columns];

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values_Temp[i, j] = matrix.values[i, j] * value;
                }
            }

            return new Matrix(values_Temp);
        }

        /// <summary>
        /// Adds a scalar value to every element of the matrix.
        /// </summary>
        /// <param name="matrix">The matrix to which the scalar value will be added.</param>
        /// <param name="value">The scalar value to add to each element.</param>
        /// <returns>A new <see cref="Matrix"/> containing the result of the addition, or <see langword="null"/> if the input matrix is null.</returns>
        public static Matrix? operator +(Matrix? matrix, double value)
        {
            if (matrix?.values == null)
            {
                return null;
            }

            int count_Rows = matrix.values.GetLength(0);
            int count_Columns = matrix.values.GetLength(1);

            double[,] values_Temp = new double[count_Rows, count_Columns];

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values_Temp[i, j] = matrix.values[i, j] + value;
                }
            }

            return new Matrix(values_Temp);
        }

        /// <summary>
        /// Adds two matrices together element-wise.
        /// </summary>
        /// <param name="matrix_1">The first matrix to add.</param>
        /// <param name="matrix_2">The second matrix to add.</param>
        /// <returns>A new <see cref="Matrix"/> containing the sum of the two matrices, or <see langword="null"/> if either input is null or if the matrices have different dimensions.</returns>
        public static Matrix? operator +(Matrix? matrix_1, Matrix? matrix_2)
        {
            if (matrix_1?.values == null || matrix_2?.values == null)
            {
                return null;
            }

            if (!matrix_1.SizeEqual(matrix_2))
            {
                return null;
            }

            Matrix result = new(matrix_1);
            if (result.values != null)
            {
                int count_Rows = result.values.GetLength(0);
                int count_Columns = result.values.GetLength(1);

                for (int i = 0; i < count_Rows; i++)
                {
                    for (int j = 0; j < count_Columns; j++)
                    {
                        result.values[i, j] += matrix_2.values[i, j];
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Creates a shallow copy of the current matrix.
        /// </summary>
        /// <returns>A clone of the current matrix.</returns>
        public override ISerializableObject? Clone()
        {
            return new Matrix((double[,]?)values?.Clone());
        }

        /// <summary>
        /// Gets the number of columns in the matrix.
        /// </summary>
        /// <returns>The column count, or -1 if values are null.</returns>
        public int ColumnCount()
        {
            if (values == null)
            {
                return -1;
            }

            return values.GetLength(1);
        }

        /// <summary>
        /// Counts the number of rows that contain at least one non-zero element.
        /// </summary>
        /// <param name="tolerance">The tolerance value for determining if an element is non-zero.</param>
        /// <returns>The count of non-zero rows.</returns>
        public int CountNonZeroRows(double tolerance = Core.Constants.Tolerance.Distance)
        {
            // Inspired by BHoM

            int rowCount = RowCount();
            int columnCount = ColumnCount();
            int count = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (System.Math.Abs(this[i, j]) >= tolerance)
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Calculates the determinant of the matrix.
        /// </summary>
        /// <returns>The determinant value, or NaN if the matrix is not square or values are null.</returns>
        public double Determinant()
        {
            if (values == null || !IsSquare())
            {
                return double.NaN;
            }

            int count = values.GetLength(0);

            if (count == 1)
            {
                return values[0, 0];
            }

            if (count == 2)
            {
                return (values[0, 0] * values[1, 1]) - (values[1, 0] * values[0, 1]);
            }

            if (count == 3)
            {
                return
                    +(values[0, 0] * ((values[1, 1] * values[2, 2]) - (values[1, 2] * values[2, 1])))
                    - (values[0, 1] * ((values[1, 0] * values[2, 2]) - (values[1, 2] * values[2, 0])))
                    + (values[0, 2] * ((values[1, 0] * values[2, 1]) - (values[1, 1] * values[2, 0])));
            }

            MathNet.Numerics.LinearAlgebra.Matrix<double>? matrix = Convert.ToMathNet(this);
            if (matrix == null)
            {
                return double.NaN;
            }

            return matrix.Determinant();
        }

        /// <summary>
        /// Calculates the eigenvalues of a 3x3 symmetric matrix.
        /// </summary>
        /// <param name="tolerance">The tolerance value for symmetry check.</param>
        /// <returns>An array containing the real eigenvalues, or null if calculation fails.</returns>
        /// <exception cref="NotImplementedException">Thrown when matrix is not 3x3 or not symmetric.</exception>
        public double[]? Eigenvalues(double tolerance = Core.Constants.Tolerance.Distance)
        {
            // Inspired by BHoM

            int rowCount = RowCount();
            int columnCount = ColumnCount();

            if (rowCount != 3 || columnCount != 3)
            {
                throw new NotImplementedException();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (System.Math.Abs(this[i, j] - this[j, i]) > tolerance)
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            double a = this[0, 0];
            double b = this[0, 1];
            double c = this[0, 2];
            double d = this[1, 1];
            double e = this[1, 2];
            double f = this[2, 2];

            double A = 1;
            double B = -(a + d + f);
            double C = a * d + a * f + d * f - b * b - c * c - e * e;
            double D = -(a * d * f + 2 * b * c * e - a * e * e - d * c * c - f * b * b);

            return Query.RealCubicRoots_ThreeRootsOnly(A, B, C, D, tolerance);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current matrix.
        /// </summary>
        /// <param name="obj">The object to compare with the current matrix.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is not Matrix matrix)
            {
                return false;
            }

            if (!SizeEqual(matrix))
            {
                return false;
            }

            if (values == null && matrix.values == null)
            {
                return true;
            }

            if (values == null || matrix.values == null)
            {
                return false;
            }

            int count_Rows = values.GetLength(0);
            int count_Columns = values.GetLength(1);

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    if (!values[i, j].Equals(matrix.values[i, j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Generates the matrix of cofactors for the current matrix, where each element is the signed minor determinant (-1)^(row+column) multiplied by the determinant of the corresponding minor matrix.
        /// </summary>
        /// <returns>The cofactor matrix, or null if values are null or the matrix is not square.</returns>
        public Matrix? GetCofactorsMatrix()
        {
            if (values == null || !IsSquare())
            {
                return null;
            }

            int count = values.GetLength(0);

            // The cofactor of the single element of a 1x1 matrix is 1 (its minor is the empty
            // determinant, which is 1 by convention).
            if (count == 1)
            {
                return new Matrix(new double[,] { { Query.MatrixCofactor(0, 0) } });
            }

            double[,] values_Temp = new double[count, count];
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    double minorDeterminant = double.NaN;
                    Matrix? matrix_Minor = GetMinorMatrix(i, j);
                    if (matrix_Minor != null)
                    {
                        minorDeterminant = matrix_Minor.Determinant();
                    }

                    values_Temp[i, j] = Query.MatrixCofactor(i, j) * minorDeterminant;
                }
            }

            return new Matrix(values_Temp);
        }

        /// <summary>
        /// Gets the hash code for the current matrix.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            if (values == null)
            {
                return -1;
            }

            int result = int.MinValue;
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    if (result == int.MinValue)
                    {
                        result = values[i, j].GetHashCode();
                    }
                    else
                    {
                        result ^= values[i, j].GetHashCode();
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Returns a new matrix that is the inverse of the current matrix.
        /// </summary>
        /// <returns>The inversed matrix, or null if the matrix is not square.</returns>
        public Matrix? GetInversed()
        {
            if (!IsSquare())
            {
                return null;
            }

            // Invert via a single MathNet conversion instead of cloning first and then converting
            // again inside Inverse() (the clone was redundant since Inverse() replaces all values).
            double[,]? values_Inversed = this.ToMathNet()?.Inverse()?.ToArray();
            if (values_Inversed == null)
            {
                return null;
            }

            return new Matrix(values_Inversed);
        }

        /// <summary>
        /// Gets the minor matrix obtained by removing the specified row and column.
        /// </summary>
        /// <param name="row">The index of the row to remove.</param>
        /// <param name="column">The index of the column to remove.</param>
        /// <returns>The resulting minor matrix, or null if values are null or dimensions are too small.</returns>
        public Matrix? GetMinorMatrix(int row, int column)
        {
            if (values == null)
            {
                return null;
            }

            int count_Rows = values.GetLength(0);
            int count_Columns = values.GetLength(1);
            if (count_Columns <= 1 || count_Rows <= 1)
            {
                return null;
            }

            double[,] values_Temp = new double[count_Columns - 1, count_Rows - 1];
            for (int i = 0; i < count_Rows; i++)
            {
                if (i == row)
                {
                    continue;
                }

                int index_row = i;
                if (index_row > row)
                {
                    index_row--;
                }

                for (int j = 0; j < count_Columns; j++)
                {
                    if (j == column)
                    {
                        continue;
                    }

                    int index_column = j;
                    if (index_column > column)
                    {
                        index_column--;
                    }

                    values_Temp[index_column, index_row] = values[i, j];
                }
            }

            return new Matrix(values_Temp);
        }

        /// <summary>
        /// Generates the matrix of minors for the current matrix.
        /// </summary>
        /// <returns>The matrix of minors, or null if values are null.</returns>
        public Matrix? GetMinorsMatrix()
        {
            if (values == null)
            {
                return null;
            }

            int count_Rows = values.GetLength(0);
            int count_Columns = values.GetLength(1);

            double[,] values_Temp = new double[count_Rows, count_Columns];
            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    double determinant = double.NaN;
                    Matrix? matrix = GetMinorMatrix(i, j);
                    if (matrix != null)
                    {
                        determinant = matrix.Determinant();
                    }

                    values_Temp[i, j] = determinant;
                }
            }

            return new Matrix(values_Temp);
        }

        /// <summary>
        /// Returns a new matrix that is the transpose of the current matrix.
        /// </summary>
        /// <returns>The transposed matrix.</returns>
        public Matrix? GetTransposed()
        {
            Matrix? result = Core.Query.Clone(this);
            result?.Transpose();
            return result;
        }

        /// <summary>
        /// Inverts the current matrix in place.
        /// </summary>
        public void Inverse()
        {
            if (!IsSquare())
            {
                return;
            }

            double[,]? values_Temp = this.ToMathNet()?.Inverse()?.ToArray();
            if (values_Temp == null)
            {
                return;
            }

            values = values_Temp;
        }

        /// <summary>
        /// Determines whether the current matrix is square.
        /// </summary>
        /// <returns>True if the matrix is square; otherwise, false.</returns>
        public bool IsSquare()
        {
            if (values == null)
            {
                return false;
            }

            return values.GetLength(0) == values.GetLength(1);
        }

        /// <summary>
        /// Multiplies the current matrix by another matrix.
        /// </summary>
        /// <param name="matrix">The matrix to multiply with.</param>
        /// <returns>The result of the multiplication, or null if dimensions are incompatible.</returns>
        public Matrix? Multiply(Matrix? matrix)
        {
            return this * matrix;
        }

        /// <summary>
        /// Multiplies every element of the current matrix by a scalar value.
        /// </summary>
        /// <param name="value">The scalar value.</param>
        /// <returns>The result of the multiplication, or null if values are null.</returns>
        public Matrix? Multiply(double value)
        {
            return this * value;
        }

        /// <summary>
        /// Negates every element of the current matrix in place.
        /// </summary>
        public void Negate()
        {
            if (values == null)
            {
                return;
            }

            int count_Rows = values.GetLength(0);
            int count_Columns = values.GetLength(1);

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values[i, j] = -values[i, j];
                }
            }
        }

        /// <summary>
        /// Calculates a tolerance value for Row Echelon Form based on matrix dimensions and maximum row sum.
        /// </summary>
        /// <param name="tolerance">The base tolerance value.</param>
        /// <returns>The calculated REF tolerance.</returns>
        public double REFTolerance(double tolerance = Core.Constants.Tolerance.Distance)
        {
            // Inspired by BHoM

            if (values == null)
            {
                return double.NaN;
            }

            int length_1 = values.GetLength(0);
            int length_2 = values.GetLength(1);
            double maxRowSum = 0;

            for (int i = 0; i < length_1; i++)
            {
                double rowSum = 0;
                for (int j = 0; j < length_2; j++)
                    rowSum += System.Math.Abs(values[i, j]);

                maxRowSum = System.Math.Max(maxRowSum, rowSum);
            }

            double result = tolerance * System.Math.Max(length_1, length_2) * maxRowSum;
            if (result >= 1)
            {
                result = 1 - tolerance;
            }

            return result;
        }

        /// <summary>
        /// Rounds every element of the current matrix to the specified tolerance in place.
        /// </summary>
        /// <param name="tolerance">The precision to round to.</param>
        public void Round(double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (values == null)
            {
                return;
            }

            int count_Rows = values.GetLength(0);
            int count_Columns = values.GetLength(1);

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values[i, j] = Core.Query.Round(values[i, j], tolerance);
                }
            }
        }

        /// <summary>
        /// Gets the number of rows in the matrix.
        /// </summary>
        /// <returns>The row count, or -1 if values are null.</returns>
        public int RowCount()
        {
            if (values == null)
            {
                return -1;
            }

            return values.GetLength(0);
        }

        /// <summary>
        /// Transforms the matrix into row echelon form or reduced row echelon form.
        /// </summary>
        /// <param name="reduced">If true, calculates the reduced row echelon form.</param>
        /// <param name="tolerance">The tolerance for zero detection during elimination.</param>
        /// <returns>A new matrix in (reduced) row echelon form, or null if cloning fails.</returns>
        public Matrix? RowEchelonForm(bool reduced = true, double tolerance = Core.Constants.Tolerance.Distance)
        {
            // Inspired by BHoM Strongly inspired by https://rosettacode.org/wiki/Reduced_row_echelon_form

            Matrix? matrix = Core.Query.Clone(this);
            if (matrix == null)
            {
                return null;
            }

            int lead = 0;
            int rowCount = matrix.RowCount();
            int columnCount = matrix.ColumnCount();

            for (int r = 0; r < rowCount; r++)
            {
                if (columnCount == lead)
                {
                    break;
                }

                int i = r;
                while (System.Math.Abs(matrix[i, lead]) < tolerance)
                {
                    i++;
                    if (i == rowCount)
                    {
                        i = r;
                        lead++;
                        if (columnCount == lead)
                        {
                            lead--;
                            break;
                        }
                    }
                }

                for (int j = 0; j < columnCount; j++)
                {
                    (matrix[i, j], matrix[r, j]) = (matrix[r, j], matrix[i, j]);
                }

                double div = matrix[r, lead];
                if (System.Math.Abs(div) >= tolerance)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        matrix[r, j] /= div;
                    }
                }

                int w = reduced ? 0 : r + 1;
                for (; w < rowCount; w++)
                {
                    if (w != r)
                    {
                        double sub = matrix[w, lead];
                        for (int k = 0; k < columnCount; k++)
                        {
                            matrix[w, k] -= (sub * matrix[r, k]);
                        }
                    }
                }

                lead++;
            }

            return matrix;
        }

        /// <summary>
        /// Sets all elements of the current matrix to a specified value in place.
        /// </summary>
        /// <param name="value">The value to set.</param>
        public void SetValues(double value)
        {
            if (values == null)
            {
                return;
            }

            int count_Rows = values.GetLength(0);
            int count_Columns = values.GetLength(1);

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values[i, j] = value;
                }
            }
        }

        /// <summary>
        /// Returns a new matrix containing the dimensions of the current matrix.
        /// </summary>
        /// <returns>A 1x2 matrix with row and column counts, or null if values are null.</returns>
        public Matrix? Size()
        {
            if (values == null)
            {
                return null;
            }

            return new Matrix([values.GetLength(0), values.GetLength(1)]);
        }

        /// <summary>
        /// Checks if the current matrix has the same dimensions as another matrix.
        /// </summary>
        /// <param name="matrix">The other matrix to compare.</param>
        /// <returns>True if sizes are equal; otherwise, false.</returns>
        public bool SizeEqual(Matrix? matrix)
        {
            if (values == null && matrix?.values == null)
            {
                return true;
            }

            if (values == null || matrix?.values == null)
            {
                return false;
            }

            return values.GetLength(0) == matrix.values.GetLength(0) && values.GetLength(1) == matrix.values.GetLength(1);
        }

        /// <summary>
        /// Converts the current matrix to a 2D array of doubles.
        /// </summary>
        /// <returns>A copy of the matrix elements as a 2D array, or null if values are null.</returns>
        public double[,]? ToArray()
        {
            if (values == null)
            {
                return null;
            }

            int count_Rows = values.GetLength(0);
            int count_Columns = values.GetLength(1);

            double[,] result = new double[count_Rows, count_Columns];
            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    result[i, j] = values[i, j];
                }
            }

            return result;
        }

        /// <summary>
        /// Transposes the current matrix in place.
        /// </summary>
        public void Transpose()
        {
            if (values == null)
            {
                return;
            }

            int count_Rows = values.GetLength(0);
            int count_Columns = values.GetLength(1);

            double[,] values_Temp = new double[count_Columns, count_Rows];

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values_Temp[j, i] = values[i, j];
                }
            }

            values = values_Temp;
        }

        /// <inheritdoc/>
        public override JsonObject? ToJsonObject()
        {
            JsonObject? jsonObject = base.ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            if (values != null)
            {
                int rows = values.GetLength(0);
                int cols = values.GetLength(1);
                JsonArray jsonArray_Rows = [];
                for (int i = 0; i < rows; i++)
                {
                    JsonArray jsonArray_Cols = [];
                    for (int j = 0; j < cols; j++)
                    {
                        jsonArray_Cols.Add(values[i, j]);
                    }
                    jsonArray_Rows.Add(jsonArray_Cols);
                }
                jsonObject["Values"] = jsonArray_Rows;
            }

            return jsonObject;
        }

        /// <inheritdoc/>
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            if (jsonObject == null)
            {
                return false;
            }

            if (jsonObject.TryGetPropertyValue("Values", out JsonNode? jsonNode_Values) && jsonNode_Values is JsonArray jsonArray_Rows)
            {
                int rows = jsonArray_Rows.Count;
                if (rows > 0 && jsonArray_Rows[0] is JsonArray jsonArray_Cols)
                {
                    int cols = jsonArray_Cols.Count;
                    double[,] values_Temp = new double[rows, cols];
                    for (int i = 0; i < rows; i++)
                    {
                        if (jsonArray_Rows[i] is JsonArray jsonArray_Row)
                        {
                            for (int j = 0; j < System.Math.Min(cols, jsonArray_Row.Count); j++)
                            {
                                if (jsonArray_Row[j] is JsonValue jsonValue && jsonValue.TryGetValue(out double val))
                                {
                                    values_Temp[i, j] = val;
                                }
                            }
                        }
                    }
                    values = values_Temp;
                }
                else
                {
                    values = null;
                }
            }

            // Create a copy of the jsonObject and remove "Values" to avoid DiGi.Core trying to deserialize it
            JsonObject jsonObject_Copy = [];
            foreach (System.Collections.Generic.KeyValuePair<string, JsonNode?> keyValuePair in jsonObject)
            {
                if (keyValuePair.Key != "Values")
                {
                    jsonObject_Copy.Add(keyValuePair.Key, keyValuePair.Value?.DeepClone());
                }
            }

            return base.FromJsonObject(jsonObject_Copy);
        }
    }
}