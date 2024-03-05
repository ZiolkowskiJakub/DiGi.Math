using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Convert
    {
        public static PolynomialEquation ToDiGi(this MathNet.Numerics.Polynomial polynomial)
        {
            if (polynomial == null)
            {
                return null;
            }

            return new PolynomialEquation(polynomial.Coefficients);
        }
    }
}
