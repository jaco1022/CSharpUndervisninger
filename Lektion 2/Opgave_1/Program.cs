using System;

namespace Opgave_1
{
    class Program
    {

        public static int fibonacci(int n)
        {
            int start = 0;
            int konstant = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = start;
                start = konstant;
                konstant = temp + konstant;

            }
            return start;
        }

        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("{0} ", fibonacci(i));
            }
        }
    }
}
