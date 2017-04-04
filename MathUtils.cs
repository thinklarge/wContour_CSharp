using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wContour
{
    public static class MathUtils
    {
        //private static bool DoubleEquals(double a, double b)
        //{
        //    if (b == 0)
        //        return (Math.Abs(a - b) < 0.0000001);
        //    else
        //    {
        //        if (Math.Abs(a - b) < 0.0000001)
        //        {
        //            if (Math.Abs(a / b - 1) < 0.001)
        //                return true;
        //            else
        //                return false;
        //        }
        //        else
        //            return false;
        //    }
        //}

        //private static bool DoubleEquals(double a, double b)
        //{
        //    double difference = Math.Abs(a * 0.00001);
        //    if (Math.Abs(a - b) < difference)
        //        return true;
        //    else
        //        return false;
        //}

        //private static bool DoubleEquals(double a, double b)
        //{
        //    //if (Math.Abs(a - b) < 0.000001)
        //    if (Math.Abs(a / b - 1) < 0.00000000001)
        //        return true;
        //    else
        //        return false;
        //}

        public static bool DoubleEquals(double a, double b)
        {
            const double epsilon = 1E-12;

            //if (Math.Abs(a - b) < 0.000001)
            //if (Math.Abs(a / b - 1) < epsilon)
            return (Math.Abs(a - b) < epsilon);
        }

        public static bool DoubleEqualsZero(double a)
        {
            return DoubleEquals(a, 0);
        }

        public static bool DoubleNotEquals(double a, double b)
        {
            return !DoubleEquals(a, b);
        }
    }
}