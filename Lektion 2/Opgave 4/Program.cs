using System;

namespace Opgave4
{
    class Program
    {

        public static int calcAge(int år)
        {
            return DateTime.Now.Year - år;
        }
        static void Main(string[] args)q
        {
            
            Console.WriteLine("Skriv din fødselsdato ind... ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Din alder: {calcAge(a)}");
            
        }
    }
}
