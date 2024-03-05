using DiGi.Core.Classes;
using DiGi.Math.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Math.Classes
{
    /// <summary>
    /// Linear Interpolation of given vlues
    /// </summary>
    public class LinearInterpolation : SerializableObject, IInterpolation
    {
        [JsonInclude, JsonPropertyName("Values")]
        private List<KeyValuePair<double, double>> values;

        public LinearInterpolation(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public LinearInterpolation(double x_1, double y_1, double x_2, double y_2)
        {
            Add(x_1, y_1);
            Add(x_2, y_2);
        }

        public LinearInterpolation()
        {
        }

        public LinearInterpolation(LinearInterpolation linearInterpolation)
        {
            if (linearInterpolation?.values != null)
            {
                foreach (KeyValuePair<double, double> keyValuePair in linearInterpolation.values)
                {
                    Add(keyValuePair);
                }
            }
        }

        public LinearInterpolation(double[,] data)
        {
            if (data == null || data.GetLength(0) < 2 || data.GetLength(1) == 0)
            {
                return;
            }

            values = new List<KeyValuePair<double, double>>();
            for (int i = 0; i < data.GetLength(1); i++)
            {
                values.Add(new KeyValuePair<double, double>(data[0, i], data[1, i]));
            }
        }

        [JsonIgnore]
        public int Count
        {
            get
            {
                if (values == null)
                    return -1;

                return values.Count;
            }
        }

        [JsonIgnore]
        public double MaxX
        {
            get
            {
                if (values == null)
                    return double.NaN;

                return values.ConvertAll(x => x.Key).Max();
            }
        }

        [JsonIgnore]
        public double MinX
        {
            get
            {
                if (values == null)
                    return double.NaN;

                return values.ConvertAll(x => x.Key).Min();
            }
        }

        public bool Add(KeyValuePair<double, double> keyValuePair)
        {
            return Add(keyValuePair.Key, keyValuePair.Value);
        }

        public bool Add(double x, double y)
        {
            if (double.IsNaN(x) || double.IsNaN(y))
            {
                return false;
            }

            if (values == null)
            {
                values = new List<KeyValuePair<double, double>>();
            }

            values.Add(new KeyValuePair<double, double>(x, y));
            return true;
        }

        public double CalculateY(double x)
        {
            List<double> ys = CalculateYs(x, 1);
            if (ys == null || ys.Count == 0)
            {
                return double.NaN;
            }

            return ys[0];
        }

        public List<double> CalculateYs(double x, int maxCount = int.MaxValue)
        {
            if (double.IsNaN(x) || !InRange(x))
            {
                return null;
            }

            double key = double.NaN;
            double value = double.NaN;

            List<double> result = new List<double>();
            foreach (KeyValuePair<double, double> keyValuePair in values)
            {
                if (x == keyValuePair.Key)
                {
                    result.Add(keyValuePair.Value);
                }
                else if (!double.IsNaN(key) && !double.IsNaN(value))
                {
                    double max = System.Math.Max(key, keyValuePair.Key);
                    double min = System.Math.Min(key, keyValuePair.Key);
                    if (x > min && x < max)
                    {
                        if (keyValuePair.Value == key)
                        {
                            result.Add(key);
                        }
                        else
                        {
                            result.Add(value + ((keyValuePair.Value - value) * ((x - key) / (keyValuePair.Key - key))));
                        }
                    }
                }

                if (result.Count >= maxCount)
                {
                    break;
                }

                key = keyValuePair.Key;
                value = keyValuePair.Value;
            }

            return result;
        }

        public bool InRange(double x)
        {
            return x >= MinX && x <= MaxX;
        }
    }
}
