using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a PolynomialEquation to a MathNet.Numerics.Polynomial object.
        /// </summary>
        /// <param name="polynomialEquation">The polynomial equation to convert.</param>
        /// <returns>A MathNet.Numerics.Polynomial object, or null if the input is null.</returns>
        public static MathNet.Numerics.Polynomial? ToMathNet(this PolynomialEquation? polynomialEquation)
        {
            if (polynomialEquation == null)
            {
                return null;
            }

            return new MathNet.Numerics.Polynomial(polynomialEquation.Coefficients);
        }
    }
}