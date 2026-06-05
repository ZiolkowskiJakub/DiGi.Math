using DiGi.Core.Interfaces;
using DiGi.Math.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Math.Classes
{
    /// <summary>
    /// Represents a 2x2 square matrix providing specialized mathematical operations and serialization capabilities.
    /// </summary>
    public class Matrix2D : Matrix, ISquareMatrix
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix2D"/> class using the provided JSON object for deserialization.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the matrix data.</param>
        public Matrix2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix2D"/> class by copying the values from an existing <see cref="Matrix2D"/> instance.
        /// </summary>
        /// <param name="matrix2D">The source matrix to copy.</param>
        public Matrix2D(Matrix2D? matrix2D)
            : base(matrix2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix2D"/> class with default dimensions of 2x2.
        /// </summary>
        public Matrix2D()
            : base(2, 2)
        {
        }

        /// <summary>
        /// Explicitly converts a two-dimensional array of doubles into a <see cref="Matrix2D"/> instance.
        /// </summary>
        /// <param name="values">The 2D double array to convert.</param>
        /// <returns>A <see cref="Matrix2D"/> instance created from the values, or null if the input is null.</returns>
        public static explicit operator Matrix2D?(double[,]? values)
        {
            if (values == null)
            {
                return null;
            }

            return Create.Matrix2D.ByValues(values);
        }

        /// <summary>
        /// Subtracts one <see cref="Matrix2D"/> from another.
        /// </summary>
        /// <param name="matrix2D_1">The first matrix operand.</param>
        /// <param name="matrix2D_2">The second matrix operand to subtract from the first.</param>
        /// <returns>The result of the subtraction as a <see cref="Matrix2D"/>, or null if either operand is null.</returns>
        public static Matrix2D? operator -(Matrix2D? matrix2D_1, Matrix2D? matrix2D_2)
        {
            if (matrix2D_1 == null || matrix2D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix2D_1) + ((Matrix)matrix2D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix2D.ByMatrix(matrix);
        }

        /// <summary>
        /// Subtracts a scalar value from every element of the <see cref="Matrix2D"/>.
        /// </summary>
        /// <param name="matrix2D">The matrix operand.</param>
        /// <param name="value">The scalar value to subtract.</param>
        /// <returns>A new <see cref="Matrix2D"/> containing the result, or null if the matrix is null.</returns>
        public static Matrix2D? operator -(Matrix2D? matrix2D, double value)
        {
            if (matrix2D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix2D + (-value);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix2D.ByMatrix(matrix);
        }

        /// <summary>
        /// Performs matrix multiplication between two <see cref="Matrix2D"/> instances.
        /// </summary>
        /// <param name="matrix2D_1">The left-hand side matrix operand.</param>
        /// <param name="matrix2D_2">The right-hand side matrix operand.</param>
        /// <returns>The resulting product as a <see cref="Matrix2D"/>, or null if either operand is null.</returns>
        public static Matrix2D? operator *(Matrix2D? matrix2D_1, Matrix2D? matrix2D_2)
        {
            if (matrix2D_1 == null || matrix2D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix2D_1) * ((Matrix)matrix2D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix2D.ByMatrix(matrix);
        }

        /// <summary>
        /// Multiplies every element of the <see cref="Matrix2D"/> by a scalar value.
        /// </summary>
        /// <param name="matrix2D">The matrix operand.</param>
        /// <param name="value">The scalar multiplier.</param>
        /// <returns>A new <see cref="Matrix2D"/> containing the result, or null if the matrix is null.</returns>
        public static Matrix2D? operator *(Matrix2D? matrix2D, double value)
        {
            if (matrix2D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix2D * value;
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix2D.ByMatrix(matrix);
        }

        /// <summary>
        /// Adds a scalar value to every element of the <see cref="Matrix2D"/>.
        /// </summary>
        /// <param name="matrix2D">The matrix operand.</param>
        /// <param name="value">The scalar value to add.</param>
        /// <returns>A new <see cref="Matrix2D"/> containing the result, or null if the matrix is null.</returns>
        public static Matrix2D? operator +(Matrix2D? matrix2D, double value)
        {
            if (matrix2D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix2D + value;
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix2D.ByMatrix(matrix);
        }

        /// <summary>
        /// Adds two <see cref="Matrix2D"/> instances together.
        /// </summary>
        /// <param name="matrix2D_1">The first matrix operand.</param>
        /// <param name="matrix2D_2">The second matrix operand to add to the first.</param>
        /// <returns>The result of the addition as a <see cref="Matrix2D"/>, or null if either operand is null.</returns>
        public static Matrix2D? operator +(Matrix2D? matrix2D_1, Matrix2D? matrix2D_2)
        {
            if (matrix2D_1 == null || matrix2D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix2D_1) + ((Matrix)matrix2D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix2D.ByMatrix(matrix);
        }

        /// <summary>
        /// Creates a deep copy of the current <see cref="Matrix2D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> representing the cloned matrix, or null.</returns>
        public override ISerializableObject? Clone()
        {
            return new Matrix2D(this);
        }
    }
}