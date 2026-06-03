using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a MathNet.Numerics.Polynomial to a PolynomialEquation object.
        /// </summary>
        /// <param name="polynomial">The MathNet polynomial to convert.</param>
        /// <returns>A PolynomialEquation object, or null if the input is null.</returns>
        public static PolynomialEquation? ToDiGi(this MathNet.Numerics.Polynomial? polynomial)
        {
            if (polynomial == null)
            {
                return null;
            }

            return new PolynomialEquation(polynomial.Coefficients);
        }
    }
}