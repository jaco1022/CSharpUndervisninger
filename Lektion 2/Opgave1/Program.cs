using System;

namespace Opgave1
{
    class Program
    {
        
        static void MyErrorMessages(string s = null)
        {
            try
            {
                Console.WriteLine(s.ToUpper());
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

        static void Main(string[] args)
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
