using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Math.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Math.Classes
{
    /// <summary>
    /// Class to perform Bilinear Interpolation on a set of data.
    /// </summary>
    public class BilinearInterpolation : SerializableObject, IInterpolation
    {
        /// <summary>
        /// The data matrix for interpolation, in [y, x] format.
        /// </summary>
        [JsonInclude, JsonPropertyName("Values")]
        private double[,]? values;

        /// <summary>
        /// Array of row (horizontal) values.
        /// </summary>
        [JsonInclude, JsonPropertyName("XArray")]
        private readonly double[]? xArray;

        /// <summary>
        /// Array of column (vertical) values.
        /// </summary>
        [JsonInclude, JsonPropertyName("YArray")]
        private readonly double[]? yArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="BilinearInterpolation"/> class using a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to be deserialized into this instance.</param>
        public BilinearInterpolation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BilinearInterpolation class using a 2D data array.
        /// </summary>
        /// <param name="data">The 2D data array.</param>
        public BilinearInterpolation(double[,]? data)
        {
            if (data == null || data.GetLength(0) < 1 || data.GetLength(1) < 1)
            {
                return;
            }

            yArray = new double[data.GetLength(0) - 1];
            for (int i = 1; i < data.GetLength(0); i++)
            {
                yArray[i - 1] = data[i, 0];
            }

            xArray = new double[data.GetLength(1) - 1];
            for (int i = 1; i < data.GetLength(1); i++)
            {
                xArray[i - 1] = data[0, i];
            }

            values = new double[data.GetLength(0) - 1, data.GetLength(1) - 1];
            for (int i = 1; i < data.GetLength(0); i++)
            {
                for (int j = 1; j < data.GetLength(1); j++)
                {
                    values[i - 1, j - 1] = data[i, j];
                }
            }
        }

        /// <summary>
        /// Copy constructor. Initializes a new instance of the BilinearInterpolation class by copying an existing instance.
        /// </summary>
        /// <param name="bilinearInterpolation">The instance to copy.</param>
        public BilinearInterpolation(BilinearInterpolation? bilinearInterpolation)
        {
            if (bilinearInterpolation != null)
            {
                xArray = bilinearInterpolation.xArray?.Clone<double>();
                yArray = bilinearInterpolation.yArray?.Clone<double>();
                if (bilinearInterpolation.values != null)
                {
                    values = new double[bilinearInterpolation.values.GetLength(0), bilinearInterpolation.values.GetLength(1)];
                    for (int i = 0; i < bilinearInterpolation.values.GetLength(0); i++)
                    {
                        for (int j = 0; j < bilinearInterpolation.values.GetLength(1); j++)
                        {
                            values[i, j] = bilinearInterpolation.values[i, j];
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Default constructor. Initializes a new instance of the BilinearInterpolation class.
        /// </summary>
        public BilinearInterpolation()
        {
        }

        /// <summary>
        /// Calculate value
        /// </summary>
        /// <param name="x">Column value (Horizontal value)</param>
        /// <param name="y">Row value (Vertical value)</param>
        /// <returns></returns>
        public double Calculate(double x, double y)
        {
            if (xArray == null || yArray == null || values == null || double.IsNaN(x) || double.IsNaN(y))
            {
                return double.NaN;
            }

            Query.NeigbourIndices(xArray, x, out int lowerIndex_X, out int upperIndex_X);
            if (lowerIndex_X == -1 || upperIndex_X == -1)
            {
                return double.NaN;
            }

            Query.NeigbourIndices(yArray, y, out int lowerIndex_Y, out int upperIndex_Y);
            if (lowerIndex_Y == -1 || upperIndex_Y == -1)
            {
                return double.NaN;
            }

            double fQ11 = values[lowerIndex_Y, lowerIndex_X];
            if (lowerIndex_X == upperIndex_X && lowerIndex_Y == upperIndex_Y)
            {
                return fQ11;
            }

            double fQ21 = values[lowerIndex_Y, upperIndex_X];
            double fQ12 = values[upperIndex_Y, lowerIndex_X];
            double fQ22 = values[upperIndex_Y, upperIndex_X];

            double y1 = yArray[lowerIndex_Y];
            double y2 = yArray[upperIndex_Y];

            if (lowerIndex_X == upperIndex_X)
            {
                return fQ11 + (fQ12 - fQ11) * (y - y1) / (y2 - y1);
            }

            double x1 = xArray[lowerIndex_X];
            double x2 = xArray[upperIndex_X];

            if (lowerIndex_Y == upperIndex_Y)
            {
                return fQ11 + (fQ22 - fQ11) * (x - x1) / (x2 - x1);
            }

            double result = fQ11 * (x2 - x) * (y2 - y);
            result += fQ21 * (x - x1) * (y2 - y);
            result += fQ12 * (x2 - x) * (y - y1);
            result += fQ22 * (x - x1) * (y - y1);
            result /= ((x2 - x1) * (y2 - y1));

            return result;
        }

        /// <inheritdoc/>
        public override JsonObject? ToJsonObject()
        {
            JsonObject? jsonObject = base.ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            if (values != null)
            {
                int rows = values.GetLength(0);
                int cols = values.GetLength(1);
                JsonArray jsonArray_Rows = [];
                for (int i = 0; i < rows; i++)
                {
                    JsonArray jsonArray_Cols = [];
                    for (int j = 0; j < cols; j++)
                    {
                        jsonArray_Cols.Add(values[i, j]);
                    }
                    jsonArray_Rows.Add(jsonArray_Cols);
                }
                jsonObject["Values"] = jsonArray_Rows;
            }

            return jsonObject;
        }

        /// <inheritdoc/>
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            if (jsonObject == null)
            {
                return false;
            }

            if (jsonObject.TryGetPropertyValue("Values", out JsonNode? jsonNode_Values) && jsonNode_Values is JsonArray jsonArray_Rows)
            {
                int rows = jsonArray_Rows.Count;
                if (rows > 0 && jsonArray_Rows[0] is JsonArray jsonArray_Cols)
                {
                    int cols = jsonArray_Cols.Count;
                    double[,] values_Temp = new double[rows, cols];
                    for (int i = 0; i < rows; i++)
                    {
                        if (jsonArray_Rows[i] is JsonArray jsonArray_Row)
                        {
                            for (int j = 0; j < System.Math.Min(cols, jsonArray_Row.Count); j++)
                            {
                                if (jsonArray_Row[j] is JsonValue jsonValue && jsonValue.TryGetValue(out double val))
                                {
                                    values_Temp[i, j] = val;
                                }
                            }
                        }
                    }
                    values = values_Temp;
                }
                else
                {
                    values = null;
                }
            }

            // Create a copy of the jsonObject and remove "Values" to avoid DiGi.Core trying to deserialize it
            JsonObject jsonObject_Copy = [];
            foreach (System.Collections.Generic.KeyValuePair<string, JsonNode?> keyValuePair in jsonObject)
            {
                if (keyValuePair.Key != "Values")
                {
                    jsonObject_Copy.Add(keyValuePair.Key, keyValuePair.Value?.DeepClone());
                }
            }

            return base.FromJsonObject(jsonObject_Copy);
        }
    }
}