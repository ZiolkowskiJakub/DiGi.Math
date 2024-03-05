using DiGi.Math.Interfaces;
using System.Collections.Generic;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.Math.Classes
{

    /// <summary>
    /// Represents a polynomial equation of the form a(n)*x^(n) + a(n-1)*x^(n-1) + a(n-2)*x^(n-2) + [...] + a(1)*x + a(0) = 0.
    /// </summary>
    public class PolynomialEquation : SerializableObject, IEquation
    {
        [JsonInclude, JsonPropertyName("Coefficients")]
        private double[] coefficients;

        public PolynomialEquation(JsonObject jsonObject)
            :base(jsonObject)
        {
        }


        /// <summary>
        /// Initializes a new instance of the PolynomialEquation class using coefficients.
        /// </summary>
        /// <param name="coefficients">The coefficients of the polynomial equation.</param>
        public PolynomialEquation(IEnumerable<double> coefficients)
        {
            if (coefficients == null)
            {
                return;
            }

            int count = coefficients.Count();

            this.coefficients = new double[count];
            for (int i = 0; i < count; i++)
            {
                this.coefficients[i] = coefficients.ElementAt(i);
            }
        }

        /// <summary>
        /// Initializes a new instance of the PolynomialEquation class using another PolynomialEquation object.
        /// </summary>
        /// <param name="polynomialEquation">The PolynomialEquation to copy from.</param>
        public PolynomialEquation(PolynomialEquation polynomialEquation)
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
        public List<double> Coefficients
        {
            get
            {
                if (coefficients == null)
                {
                    return null;
                }

                List<double> result = new List<double>();
                foreach (double variable in coefficients)
                {
                    result.Add(variable);
                }

                return result;
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
        /// Implicitly converts a LinearEquation to a PolynomialEquation.
        /// </summary>
        /// <param name="linearEquation">The LinearEquation to convert.</param>
        public static explicit operator PolynomialEquation(LinearEquation linearEquation)
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
            int count = coefficients.Length;

            double result = 0;
            for (int i = 1; i < count; i++)
            {
                result += System.Math.Pow(value, i) * coefficients[i];
            }

            result += coefficients[0];

            return result;
        }

        /// <summary>
        /// Evaluates the polynomial equation for a given set of x values.
        /// </summary>
        /// <param name="values">The x values to evaluate the polynomial equation for.</param>
        /// <returns>The results of the polynomial equation.</returns>
        public List<double> Evaluate(IEnumerable<double> values)
        {
            if (values == null)
            {
                return null;
            }

            List<double> result = null;

            int count = coefficients.Length;
            if (count < 5 || values.Count() < 1000)
            {
                result = new List<double>();
                foreach (double value in values)
                {
                    result.Add(Evaluate(value));
                }
            }
            else
            {
                count = values.Count();

                result = Enumerable.Repeat(double.NaN, count).ToList();
                Parallel.For(0, count, (int i) =>
                {
                    result[i] = Evaluate(values.ElementAt(i));
                });
            }

            return result;
        }
    }
}
