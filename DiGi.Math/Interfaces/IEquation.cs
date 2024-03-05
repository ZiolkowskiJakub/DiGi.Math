using System.Collections.Generic;

namespace DiGi.Math.Interfaces
{
    public interface IEquation : Core.Interfaces.ISerializableObject
    {
        double Evaluate(double value);

        List<double> Evaluate(IEnumerable<double> values);
    }
}
