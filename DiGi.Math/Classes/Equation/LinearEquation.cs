using DiGi.Core.Classes;
using DiGi.Math.Interfaces;
using System.Collections.Generic;
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
        private readonly double a;

        [JsonInclude, JsonPropertyName("B")]
        private readonly double b;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearEquation"/> class using a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the equation data.</param>
        public LinearEquation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearEquation"/> class with specified coefficients A and B.
        /// </summary>
        /// <param name="a">The coefficient A (slope) of the linear equation.</param>
        /// <param name="b">The coefficient B (y-intercept) of the linear equation.</param>
        public LinearEquation(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearEquation"/> class by copying an existing <see cref="LinearEquation"/> instance.
        /// </summary>
        /// <param name="linearEquation">The source equation to copy from.</param>
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
                return [b, a];
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
        public List<double>? Evaluate(IEnumerable<double>? values)
        {
            if (values == null)
            {
                return null;
            }

            List<double> result = [];
            foreach (double value in values)
            {
                result.Add(Evaluate(value));
            }

            return result;
        }
    }
}