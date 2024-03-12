using System.Collections.Generic;
using System.Linq;

namespace DiGi.Math
{
    public static partial class Create
    {
        public static partial class Matrix
        {
            public static Classes.Matrix Identity(int count = 3)
            {
                Classes.Matrix matrix = new Classes.Matrix(new double[count, count]);
                for (int i = 0; i < count; i++)
                {
                    matrix[i, i] = 1;
                }

                return matrix;
            }

            public static Classes.Matrix Unset(int rowCount, int columnCount)
            {
                Classes.Matrix result = new Classes.Matrix(rowCount, columnCount);
                result.SetValues(double.MinValue);

                return result;
            }

            public static Classes.Matrix Scale(IEnumerable<double> values)
            {
                if (values == null)
                    return null;

                int count = values.Count();

                Classes.Matrix matrix = Identity(count + 1);

                for (int i = 0; i < count; i++)
                {
                    matrix[i, i] = values.ElementAt(i);
                }

                return matrix;
            }

            public static Classes.Matrix Scale(int count, double factor)
            {
                Classes.Matrix matrix = Identity(count + 1);

                for (int i = 0; i < count; i++)
                {
                    matrix[i, i] = factor;
                }

                return matrix;
            }
        }


    }
}
