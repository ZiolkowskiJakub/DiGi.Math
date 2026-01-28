using DiGi.Core.Interfaces;
using DiGi.Math.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Math.Classes
{
    public class Matrix : Core.Classes.SerializableObject, IMatrix
    {
        [JsonInclude, JsonPropertyName("Values")]
        private double[,]? values;

        public Matrix(int rowCount, int columnCount)
        {
            values = new double[rowCount, columnCount];
        }

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

        public Matrix(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

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

        public static explicit operator Matrix?(double[,]? values)
        {
            if (values == null)
            {
                return null;
            }

            return new Matrix(values);
        }

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

        public static Matrix? operator -(Matrix? matrix, double value)
        {
            return matrix + (-value);
        }

        public static Matrix? operator *(Matrix? matrix_1, Matrix? matrix_2)
        {
            if (matrix_1 == null || matrix_2 == null)
            {
                return null;
            }

            int columnCount_1 = matrix_1.ColumnCount();

            if (columnCount_1 != matrix_2.RowCount())
            {
                return null;
            }

            int rowCount_1 = matrix_1.RowCount();

            int columnCount_2 = matrix_2.ColumnCount();

            Matrix result = new(rowCount_1, columnCount_2);
            for (int i = 0; i < rowCount_1; i++)
            {
                for (int j = 0; j < columnCount_2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < columnCount_1; k++)
                    {
                        result[i, j] += matrix_1[i, k] * matrix_2[k, j];
                    }
                }
            }

            return result;
        }

        public static Matrix? operator *(Matrix? matrix, double value)
        {
            if (matrix?.values == null)
            {
                return null;
            }

            int count_Rows = matrix.values.GetLength(0);
            int count_Columns = matrix.values.GetLength(1);

            double[,] values_Temp = new double[count_Columns, count_Rows];

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values_Temp[i, j] = matrix.values[i, j] * value;
                }
            }

            return new Matrix(values_Temp);
        }

        public static Matrix? operator +(Matrix? matrix, double value)
        {
            if (matrix?.values == null)
            {
                return null;
            }

            int count_Rows = matrix.values.GetLength(0);
            int count_Columns = matrix.values.GetLength(1);

            double[,] values_Temp = new double[count_Columns, count_Rows];

            for (int i = 0; i < count_Rows; i++)
            {
                for (int j = 0; j < count_Columns; j++)
                {
                    values_Temp[i, j] = matrix.values[i, j] + value;
                }
            }

            return new Matrix(values_Temp);
        }

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

        public override ISerializableObject? Clone()
        {
            return new Matrix((double[,]?)values?.Clone());
        }

        public int ColumnCount()
        {
            if (values == null)
            {
                return -1;
            }

            return values.GetLength(1);
        }

        public int CountNonZeroRows(double tolerance = Core.Constans.Tolerance.Distance)
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

        public double[]? Eigenvalues(double tolerance = Core.Constans.Tolerance.Distance)
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

        public Matrix? GetCofactorsMatrix()
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
                    values_Temp[i, j] = Query.MatrixCofactor(i, j);
                }
            }

            return new Matrix(values_Temp);
        }

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

        public Matrix? GetInversed()
        {
            if (!IsSquare())
            {
                return null;
            }

            Matrix? result = Core.Query.Clone(this);
            result?.Inverse();
            return result;
        }

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

        public Matrix? GetTransposed()
        {
            Matrix? result = Core.Query.Clone(this);
            result?.Transpose();
            return result;
        }

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

        public bool IsSquare()
        {
            if (values == null)
            {
                return false;
            }

            return values.GetLength(0) == values.GetLength(1);
        }

        public Matrix? Multiply(Matrix? matrix)
        {
            return this * matrix;
        }

        public Matrix? Multiply(double value)
        {
            return this * value;
        }

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

        public double REFTolerance(double tolerance = Core.Constans.Tolerance.Distance)
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

        public void Round(double tolerance = Core.Constans.Tolerance.Distance)
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

        public int RowCount()
        {
            if (values == null)
            {
                return -1;
            }

            return values.GetLength(0);
        }

        public Matrix? RowEchelonForm(bool reduced = true, double tolerance = Core.Constans.Tolerance.Distance)
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

        public Matrix? Size()
        {
            if (values == null)
            {
                return null;
            }

            return new Matrix([values.GetLength(0), values.GetLength(1)]);
        }

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
    }
}