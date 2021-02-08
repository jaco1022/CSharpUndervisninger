using System;

namespace Opgave5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var rand = new Random();

            //Random ints
            Console.WriteLine("Five random integer values:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,15:N0}", rand.Next());
            Console.WriteLine();

            // Next double
            Console.WriteLine("Five Doubles between 0 and 5.");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N3}", rand.NextDouble() * 5);
        }
    }
}
