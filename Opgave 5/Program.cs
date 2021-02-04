using System;

namespace ØvelserLektion1
{
    class Program
    {
        public static double Max(params double[] arr)
        {
            double res = 0;
            foreach (var item in arr)
            {
                if (item > res)
                {
                    res = item;
                }

            }
            return res;

        }


        static void Main(string[] args)

        {
            double m1 = Max(28.5, 17.2);
            double m2 = Max(4.0, 10.8, 34.25, 2.0, 23.6);

            Console.WriteLine(m1 + " " + m2);
            Console.ReadLine();

        }

    }
}