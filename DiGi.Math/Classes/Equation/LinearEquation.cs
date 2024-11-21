using DiGi.Math.Interfaces;
using System.Collections.Generic;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Math.Classes
{

    /// <summary>
    /// Equation in format y = Ax + B
    /// </summary>
    public class LinearEquation : SerializableObject, IEquation
    {
        [JsonInclude, JsonPropertyName("A")]
        private double a;

        [JsonInclude, JsonPropertyName("B")]
        private double b;

        public LinearEquation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public LinearEquation(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public LinearEquation(LinearEquation linearEquation)
        {
            if (linearEquation != null)
            {
                a = linearEquation.a;
                b = linearEquation.b;
            }
        }

        /// <summary>
        /// Coefficient A in the equation
        /// </summary>
        [JsonIgnore]
        public double A
        {
            get
            {
                return a;
            }
        }

        /// <summary>
        /// Coefficient B in the equation
        /// </summary>
        [JsonIgnore]
        public double B
        {
            get
            {
                return b;
            }
        }

        /// <summary>
        /// Gets the coefficients of the equation
        /// </summary>
        public List<double> Coefficients
        {
            get
            {
                return new List<double>() { b, a };
            }
        }

        /// <summary>
        /// Evaluates the equation for a given value of x
        /// </summary>
        /// <param name="value">The value of x</param>
        /// <returns>The value of y for the given value of x</returns>
        public double Evaluate(double value)
        {
            if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(value))
            {
                return double.NaN;
            }

            return b + a * value;
        }

        /// <summary>
        /// Evaluates the equation for a collection of values of x
        /// </summary>
        /// <param name="values">The collection of values of x</param>
        /// <returns>A list of corresponding values of y</returns>
        public List<double> Evaluate(IEnumerable<double> values)
        {
            if (values == null)
                return null;

            List<double> result = new List<double>();
            foreach (double value in values)
            {
                result.Add(Evaluate(value));
            }

            return result;
        }
    }
}
