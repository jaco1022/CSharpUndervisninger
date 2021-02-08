using System;
using System.Collections.Generic;

namespace TestProjekt
{
    class Program
    {
        static void Main()
        {
            int myInt = 0;
            string navn = "jacob";
            bool tr = true;

            var minVar = 17;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Tallet er nu {i}");
            //}

            string[] strA = new String[6];
            int[] intA = { 5, 56, -100, 18, 89 };
            String[] strB = { "52", "hund", "sune", "ost", "89"};

            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(7);
            lst.Add(345);
            lst.Add(6456);
            
            lst.ForEach(Console.WriteLine);

            if (true)
                Console.WriteLine();
            else
                Console.WriteLine();


            //foreach (var item in lst)
            //{
            //    Console.WriteLine($"Elementet i vores array er {item}");
            //}

        }
    }
}
