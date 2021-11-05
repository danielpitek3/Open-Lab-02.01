using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        static double[] Create5Numbers()
        {
            double[] array1 = new double[] { 1.3, 3.4, 5.8, 7.2, 9.1 };
            return array1;
        }

        static double GetSecond(double[] numbers)
        {
            double[] e = Create5Numbers();
            return e[1];
        }
    }
}