using System;

namespace Opgave6
{
    class Program
    {

        static void MyErrorMessages(int s = 0)
        {
            try
            {
                Console.WriteLine(s.Equals(-1));
            }
            catch (NullReferenceException e)
            {
                throw new ApplicationException("Din streng er null");
            }
            catch (Exception x)
            {
                Console.WriteLine($"Fejl:  {x.Message}");
            }
            finally
            {
                Console.WriteLine($"Indholdet af din streng er... {s} ");
            }

        }

        static void Main(int[] args)
        {
            try
            {
                MyErrorMessages();
            }
            catch
            {
                Console.WriteLine("Det gik sku galt igen min ven");
            }
        }
    }
}
