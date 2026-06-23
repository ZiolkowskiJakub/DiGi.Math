using DiGi.Core.Interfaces;
using DiGi.Math.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Math.Classes
{
    /// <summary>
    /// Represents a 4x4 square matrix providing mathematical operations and serialization capabilities.
    /// </summary>
    public class Matrix4D : Matrix, ISquareMatrix
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4D"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the matrix data.</param>
        public Matrix4D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4D"/> class by copying an existing matrix.
        /// </summary>
        /// <param name="matrix4D">The source <see cref="Matrix4D"/> to copy.</param>
        public Matrix4D(Matrix4D? matrix4D)
            : base(matrix4D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4D"/> class as a 4x4 matrix.
        /// </summary>
        public Matrix4D()
            : base(4, 4)
        {
        }

        /// <summary>
        /// Explicitly converts a two-dimensional array of doubles to a <see cref="Matrix4D"/>.
        /// </summary>
        /// <param name="values">The 2D double array containing the matrix elements.</param>
        /// <returns>A <see cref="Matrix4D"/> instance created from the values, or null if the input is null.</returns>
        public static explicit operator Matrix4D?(double[,]? values)
        {
            if (values == null)
            {
                return null;
            }

            return Create.Matrix4D.ByValues(values);
        }

        /// <summary>
        /// Subtracts one <see cref="Matrix4D"/> from another.
        /// </summary>
        /// <param name="matrix4D_1">The first matrix.</param>
        /// <param name="matrix4D_2">The second matrix to subtract from the first.</param>
        /// <returns>The result of the subtraction as a <see cref="Matrix4D"/>, or null if either operand is null.</returns>
        public static Matrix4D? operator -(Matrix4D? matrix4D_1, Matrix4D? matrix4D_2)
        {
            if (matrix4D_1 == null || matrix4D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix4D_1) - ((Matrix)matrix4D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix4D.ByMatrix(matrix);
        }

        /// <summary>
        /// Subtracts a scalar value from each element of the <see cref="Matrix4D"/>.
        /// </summary>
        /// <param name="matrix4D">The matrix to subtract from.</param>
        /// <param name="value">The scalar value to subtract.</param>
        /// <returns>A new <see cref="Matrix4D"/> containing the result, or null if the matrix is null.</returns>
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

        /// <summary>
        /// Multiplies two <see cref="Matrix4D"/> matrices.
        /// </summary>
        /// <param name="matrix4D_1">The first matrix.</param>
        /// <param name="matrix4D_2">The second matrix.</param>
        /// <returns>The result of the multiplication as a <see cref="Matrix4D"/>, or null if either operand is null.</returns>
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

        /// <summary>
        /// Multiplies each element of the <see cref="Matrix4D"/> by a scalar value.
        /// </summary>
        /// <param name="matrix4D">The matrix to multiply.</param>
        /// <param name="value">The scalar multiplier.</param>
        /// <returns>A new <see cref="Matrix4D"/> containing the result, or null if the matrix is null.</returns>
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

        /// <summary>
        /// Adds a scalar value to each element of the <see cref="Matrix4D"/>.
        /// </summary>
        /// <param name="matrix4D">The matrix to add to.</param>
        /// <param name="value">The scalar value to add.</param>
        /// <returns>A new <see cref="Matrix4D"/> containing the result, or null if the matrix is null.</returns>
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

        /// <summary>
        /// Adds two <see cref="Matrix4D"/> matrices together.
        /// </summary>
        /// <param name="matrix4D_1">The first matrix.</param>
        /// <param name="matrix4D_2">The second matrix to add to the first.</param>
        /// <returns>The result of the addition as a <see cref="Matrix4D"/>, or null if either operand is null.</returns>
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

        /// <summary>
        /// Creates a deep copy of the current <see cref="Matrix4D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> representing the cloned matrix, or null.</returns>
        public override ISerializableObject? Clone()
        {
            return new Matrix4D(this);
        }
    }
}