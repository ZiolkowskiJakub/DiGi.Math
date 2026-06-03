using System.Collections.Generic;

namespace DiGi.Math.Interfaces
{
    /// <summary>
    /// Defines the members of an equation.
    /// </summary>
    public interface IEquation : Core.Interfaces.ISerializableObject
    {
        /// <summary>
        /// Evaluates the equation for a given value.
        /// </summary>
        /// <param name="value">The value to evaluate.</param>
        /// <returns>The result of the evaluation.</returns>
        double Evaluate(double value);

        /// <summary>
        /// Evaluates the equation for a given set of values.
        /// </summary>
        /// <param name="values">The values to evaluate.</param>
        /// <returns>The results of the evaluations.</returns>
        List<double>? Evaluate(IEnumerable<double>? values);
    }
}