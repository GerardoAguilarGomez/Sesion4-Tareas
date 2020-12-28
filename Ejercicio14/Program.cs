using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte el radio del circulo");
            string radio = Console.ReadLine();

            const double pi= 3.141592;

            double r = Convert.ToDouble(radio);

            double total = pi * Math.Pow(r, 2);

            Console.WriteLine("El área es {0}", total);
        }
    }
}
