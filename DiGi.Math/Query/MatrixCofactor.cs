namespace DiGi.Math
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the sign component of a matrix cofactor based on the provided row and column indices.
        /// </summary>
        /// <param name="row">The zero-based index of the row.</param>
        /// <param name="column">The zero-based index of the column.</param>
        /// <returns>Returns 1.0 if the sum of the row and column indices is even, otherwise returns -1.0.</returns>
        public static double MatrixCofactor(int row, int column)
        {
            if ((row + column) % 2 == 1)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}