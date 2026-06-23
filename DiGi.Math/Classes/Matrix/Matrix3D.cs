using DiGi.Core.Interfaces;
using DiGi.Math.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Math.Classes
{
    /// <summary>
    /// Represents a 3x3 square matrix used for three-dimensional mathematical operations.
    /// </summary>
    public class Matrix3D : Matrix, ISquareMatrix
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix3D"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the matrix data.</param>
        public Matrix3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix3D"/> class by copying an existing <see cref="Matrix3D"/> instance.
        /// </summary>
        /// <param name="matrix3D">The source <see cref="Matrix3D"/> to copy.</param>
        public Matrix3D(Matrix3D? matrix3D)
            : base(matrix3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix3D"/> class as a 3x3 matrix.
        /// </summary>
        public Matrix3D()
            : base(3, 3)
        {
        }

        /// <summary>
        /// Explicitly converts a two-dimensional array of doubles to a <see cref="Matrix3D"/>.
        /// </summary>
        /// <param name="values">The 2D double array containing the matrix elements.</param>
        /// <returns>A <see cref="Matrix3D"/> instance created from the values, or null if the input is null.</returns>
        public static explicit operator Matrix3D?(double[,]? values)
        {
            if (values == null)
            {
                return null;
            }

            return Create.Matrix3D.ByValues(values);
        }

        /// <summary>
        /// Subtracts one <see cref="Matrix3D"/> from another.
        /// </summary>
        /// <param name="matrix3D_1">The first <see cref="Matrix3D"/>.</param>
        /// <param name="matrix3D_2">The second <see cref="Matrix3D"/> to subtract from the first.</param>
        /// <returns>The result of the subtraction as a <see cref="Matrix3D"/>, or null if either operand is null.</returns>
        public static Matrix3D? operator -(Matrix3D? matrix3D_1, Matrix3D? matrix3D_2)
        {
            if (matrix3D_1 == null || matrix3D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix3D_1) - ((Matrix)matrix3D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        /// <summary>
        /// Subtracts a scalar value from each element of the <see cref="Matrix3D"/>.
        /// </summary>
        /// <param name="matrix3D">The <see cref="Matrix3D"/> instance.</param>
        /// <param name="value">The double value to subtract.</param>
        /// <returns>A new <see cref="Matrix3D"/> containing the result, or null if the matrix is null.</returns>
        public static Matrix3D? operator -(Matrix3D? matrix3D, double value)
        {
            if (matrix3D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix3D + (-value);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        /// <summary>
        /// Performs matrix multiplication between two <see cref="Matrix3D"/> instances.
        /// </summary>
        /// <param name="matrix3D_1">The left-hand side <see cref="Matrix3D"/>.</param>
        /// <param name="matrix3D_2">The right-hand side <see cref="Matrix3D"/>.</param>
        /// <returns>The resulting <see cref="Matrix3D"/> from the multiplication, or null if either operand is null.</returns>
        public static Matrix3D? operator *(Matrix3D? matrix3D_1, Matrix3D? matrix3D_2)
        {
            if (matrix3D_1 == null || matrix3D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix3D_1) * ((Matrix)matrix3D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        /// <summary>
        /// Multiplies each element of the <see cref="Matrix3D"/> by a scalar value.
        /// </summary>
        /// <param name="matrix3D">The <see cref="Matrix3D"/> instance.</param>
        /// <param name="value">The double value to multiply by.</param>
        /// <returns>A new <see cref="Matrix3D"/> containing the result, or null if the matrix is null.</returns>
        public static Matrix3D? operator *(Matrix3D? matrix3D, double value)
        {
            if (matrix3D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix3D * value;
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        /// <summary>
        /// Adds a scalar value to each element of the <see cref="Matrix3D"/>.
        /// </summary>
        /// <param name="matrix3D">The <see cref="Matrix3D"/> instance.</param>
        /// <param name="value">The double value to add.</param>
        /// <returns>A new <see cref="Matrix3D"/> containing the result, or null if the matrix is null.</returns>
        public static Matrix3D? operator +(Matrix3D? matrix3D, double value)
        {
            if (matrix3D == null)
            {
                return null;
            }

            Matrix? matrix = (Matrix)matrix3D + value;
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        /// <summary>
        /// Adds two <see cref="Matrix3D"/> instances together.
        /// </summary>
        /// <param name="matrix3D_1">The first <see cref="Matrix3D"/>.</param>
        /// <param name="matrix3D_2">The second <see cref="Matrix3D"/> to add to the first.</param>
        /// <returns>The result of the addition as a <see cref="Matrix3D"/>, or null if either operand is null.</returns>
        public static Matrix3D? operator +(Matrix3D? matrix3D_1, Matrix3D? matrix3D_2)
        {
            if (matrix3D_1 == null || matrix3D_2 == null)
            {
                return null;
            }

            Matrix? matrix = ((Matrix)matrix3D_1) + ((Matrix)matrix3D_2);
            if (matrix == null)
            {
                return null;
            }

            return Create.Matrix3D.ByMatrix(matrix);
        }

        /// <summary>
        /// Creates a deep copy of the current <see cref="Matrix3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> representing the cloned matrix.</returns>
        public override ISerializableObject? Clone()
        {
            return new Matrix3D(this);
        }
    }
}