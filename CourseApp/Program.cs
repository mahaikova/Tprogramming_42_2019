using System;

namespace CourseApp
{
    public class Program
    {
        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            int j = 0;
            var y = new double[5];

            for (var i = xn; i < xk; i += dx)
            {
                y[j] = (a + Math.Pow(Math.Tan(b * i), 2.0)) / (b + (1.0 / Math.Pow(Math.Tan(a * i), 2)));
                j++;
            }

            return y;
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];

            for (var i = 0; i < y.Length; i++)
            {
                y[i] = (a + Math.Pow(Math.Tan(b * x[i]), 2.0)) / (b + (1.0 / Math.Pow(Math.Tan(a * x[i]), 2)));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 0.1;
            const double b = 0.5;
            const double xn = 0.15;
            const double xk = 1.37;
            const double dx = 0.25;

            var resSingle = TaskA(a, b, xn, xk, dx);
            foreach (var item in resSingle)
            {
                Console.WriteLine($"y = {item}");
            }

            var x = new double[] { 0.2, 0.3, 0.44, 0.6, 0.56 };
            var taskBRes = TaskB(a, b, x);
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y1 = {item}");
            }

            Console.ReadLine();
        }
    }
}