﻿using DiGi.Math.Classes;

namespace DiGi.Math
{
    public static partial class Create
    {
        public static LinearEquation LinearEquation(double x_1, double y_1, double x_2, double y_2)
        {
            if (double.IsNaN(x_1) || double.IsNaN(x_2) || double.IsNaN(y_1) || double.IsNaN(y_2))
            {
                return null;
            }

            double a = double.NaN;
            double b = double.NaN;

            double x = x_2 - x_1;
            if (x == 0)
            {
                return null;
            }

            a = (y_2 - y_1) / x;
            if (double.IsNaN(a))
            {
                return null;
            }

            double ax = a * x_1;
            double y = y_1;
            if (ax == 0)
            {
                ax = a * x_2;
                y = y_2;
            }

            if (ax == 0)
            {
                return null;
            }

            b = y - ax;

            return new LinearEquation(a, b);
        }
    }
}
