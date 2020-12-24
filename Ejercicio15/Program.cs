using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte un valor:");
            string n1 = Console.ReadLine();
            int num = Convert.ToInt32(n1);

            if (num % 2 == 0)
            {
                Console.WriteLine("Es divisible entre 2");
            }
            else
            {
                Console.WriteLine("No es divisible entre 2");
            }
        }
    }
}
