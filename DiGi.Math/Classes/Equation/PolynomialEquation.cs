using DiGi.Core.Classes;
using DiGi.Math.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DiGi.Math.Classes
{
    /// <summary>
    /// Represents a polynomial equation of the form a(n)*x^(n) + a(n-1)*x^(n-1) + a(n-2)*x^(n-2) + [...] + a(1)*x + a(0) = 0.
    /// </summary>
    public class PolynomialEquation : SerializableObject, IEquation
    {
        [JsonInclude, JsonPropertyName("Coefficients")]
        private readonly double[]? coefficients;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolynomialEquation"/> class using a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the polynomial equation data.</param>
        public PolynomialEquation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PolynomialEquation class using coefficients.
        /// </summary>
        /// <param name="coefficients">The coefficients of the polynomial equation.</param>
        public PolynomialEquation(IEnumerable<double>? coefficients)
        {
            if (coefficients == null)
            {
                return;
            }

            this.coefficients = [.. coefficients];
        }

        /// <summary>
        /// Initializes a new instance of the PolynomialEquation class using another PolynomialEquation object.
        /// </summary>
        /// <param name="polynomialEquation">The PolynomialEquation to copy from.</param>
        public PolynomialEquation(PolynomialEquation? polynomialEquation)
        {
            if (polynomialEquation == null || polynomialEquation.coefficients == null)
            {
                return;
            }

            int count = polynomialEquation.coefficients.Length;

            coefficients = new double[count];
            for (int i = 0; i < count; i++)
            {
                coefficients[i] = polynomialEquation.coefficients[i];
            }
        }

        /// <summary>
        /// Gets the coefficients of the polynomial equation.
        /// </summary>
        [JsonIgnore]
        public List<double>? Coefficients
        {
            get
            {
                if (coefficients == null)
                {
                    return null;
                }

                return [.. coefficients];
            }
        }

        /// <summary>
        /// Gets the degree of the polynomial equation.
        /// </summary>
        [JsonIgnore]
        public int Degree
        {
            get
            {
                if (coefficients == null)
                {
                    return -1;
                }

                return coefficients.Length - 1;
            }
        }

        /// <summary>
        /// Explicitly converts a <see cref="LinearEquation"/> to a <see cref="PolynomialEquation"/>.
        /// </summary>
        /// <param name="linearEquation">The linear equation to convert.</param>
        /// <returns>A <see cref="PolynomialEquation"/> instance created from the provided linear equation, or null if the input is null.</returns>
        public static explicit operator PolynomialEquation?(LinearEquation? linearEquation)
        {
            if (linearEquation == null)
            {
                return null;
            }

            return new PolynomialEquation(linearEquation.Coefficients);
        }

        /// <summary>
        /// Evaluates the polynomial equation for a given x value.
        /// </summary>
        /// <param name="value">The x value to evaluate the polynomial equation for.</param>
        /// <returns>The result of the polynomial equation.</returns>
        public double Evaluate(double value)
        {
            if (coefficients == null || coefficients.Length == 0)
            {
                return double.NaN;
            }

            // Horner's method: avoids one System.Math.Pow per term (O(degree) multiply-adds),
            // which is both faster and numerically more stable than summing value^i terms.
            int count = coefficients.Length;
            double result = coefficients[count - 1];
            for (int i = count - 2; i >= 0; i--)
            {
                result = (result * value) + coefficients[i];
            }

            return result;
        }

        /// <summary>
        /// Evaluates the polynomial equation for a given set of x values.
        /// </summary>
        /// <param name="values">The x values to evaluate the polynomial equation for.</param>
        /// <returns>The results of the polynomial equation.</returns>
        public List<double>? Evaluate(IEnumerable<double>? values)
        {
            if (values == null || coefficients == null)
            {
                return null;
            }

            // Materialize once so the parallel branch uses O(1) indexing instead of
            // re-enumerating the source per element (the previous ElementAt usage was O(n^2)
            // and re-enumerated a shared IEnumerable concurrently across threads).
            IList<double> valueList = values as IList<double> ?? [.. values];
            int count = valueList.Count;

            if (coefficients.Length < 5 || count < 1000)
            {
                List<double> result = new(count);
                for (int i = 0; i < count; i++)
                {
                    result.Add(Evaluate(valueList[i]));
                }

                return result;
            }

            double[] values_Result = new double[count];
            Parallel.For(0, count, i =>
            {
                values_Result[i] = Evaluate(valueList[i]);
            });

            return [.. values_Result];
        }
    }
}