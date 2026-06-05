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
        private List<KeyValuePair<double, double>>? values;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearInterpolation"/> class using a <see cref="JsonObject"/> for deserialization.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the interpolation data.</param>
        public LinearInterpolation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearInterpolation"/> class with two initial data points.
        /// </summary>
        /// <param name="x_1">The X coordinate of the first point.</param>
        /// <param name="y_1">The Y coordinate of the first point.</param>
        /// <param name="x_2">The X coordinate of the second point.</param>
        /// <param name="y_2">The Y coordinate of the second point.</param>
        public LinearInterpolation(double x_1, double y_1, double x_2, double y_2)
        {
            Add(x_1, y_1);
            Add(x_2, y_2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearInterpolation"/> class.
        /// </summary>
        public LinearInterpolation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearInterpolation"/> class by copying values from an existing interpolation object.
        /// </summary>
        /// <param name="linearInterpolation">The source <see cref="LinearInterpolation"/> instance to copy.</param>
        public LinearInterpolation(LinearInterpolation? linearInterpolation)
        {
            if (linearInterpolation?.values != null)
            {
                foreach (KeyValuePair<double, double> keyValuePair in linearInterpolation.values)
                {
                    Add(keyValuePair);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearInterpolation"/> class using a 2D array where the first dimension represents axes (0 for X, 1 for Y) and the second dimension represents points.
        /// </summary>
        /// <param name="data">A 2D array containing coordinate pairs.</param>
        public LinearInterpolation(double[,]? data)
        {
            if (data == null || data.GetLength(0) < 2 || data.GetLength(1) == 0)
            {
                return;
            }

            values = [];
            for (int i = 0; i < data.GetLength(1); i++)
            {
                values.Add(new KeyValuePair<double, double>(data[0, i], data[1, i]));
            }
        }

        /// <summary>
        /// Gets the number of data points stored in the interpolation set. Returns -1 if the values collection is not initialized.
        /// </summary>
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

        /// <summary>
        /// Gets the maximum X value among all stored data points. Returns <see cref="double.NaN"/> if no values are present.
        /// </summary>
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

        /// <summary>
        /// Gets the minimum X value among all stored data points. Returns <see cref="double.NaN"/> if no values are present.
        /// </summary>
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

        /// <summary>
        /// Adds a coordinate pair to the interpolation set.
        /// </summary>
        /// <param name="keyValuePair">A <see cref="KeyValuePair{TKey, TValue}"/> where Key is X and Value is Y.</param>
        /// <returns>True if the point was successfully added; otherwise, false.</returns>
        public bool Add(KeyValuePair<double, double> keyValuePair)
        {
            return Add(keyValuePair.Key, keyValuePair.Value);
        }

        /// <summary>
        /// Adds a coordinate pair to the interpolation set.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <returns>True if the point was added; false if either X or Y is <see cref="double.NaN"/>.</returns>
        public bool Add(double x, double y)
        {
            if (double.IsNaN(x) || double.IsNaN(y))
            {
                return false;
            }

            values ??= [];

            values.Add(new KeyValuePair<double, double>(x, y));
            return true;
        }

        /// <summary>
        /// Calculates a single interpolated Y value for the given X coordinate.
        /// </summary>
        /// <param name="x">The X coordinate to interpolate.</param>
        /// <returns>The interpolated Y value, or <see cref="double.NaN"/> if interpolation is not possible.</returns>
        public double CalculateY(double x)
        {
            List<double>? ys = CalculateYs(x, 1);
            if (ys == null || ys.Count == 0)
            {
                return double.NaN;
            }

            return ys[0];
        }

        /// <summary>
        /// Calculates a list of interpolated Y values for the given X coordinate.
        /// </summary>
        /// <param name="x">The X coordinate to interpolate.</param>
        /// <param name="maxCount">The maximum number of results to return.</param>
        /// <returns>A <see cref="List{T}"/> of interpolated Y values, or null if the input is invalid or out of range.</returns>
        public List<double>? CalculateYs(double x, int maxCount = int.MaxValue)
        {
            if (double.IsNaN(x) || !InRange(x) || values == null)
            {
                return null;
            }

            double key = double.NaN;
            double value = double.NaN;

            List<double> result = [];
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

        /// <summary>
        /// Checks whether the specified X coordinate falls within the range defined by the minimum and maximum stored X values.
        /// </summary>
        /// <param name="x">The X coordinate to check.</param>
        /// <returns>True if the value is within the inclusive range [MinX, MaxX]; otherwise, false.</returns>
        public bool InRange(double x)
        {
            return x >= MinX && x <= MaxX;
        }
    }
}