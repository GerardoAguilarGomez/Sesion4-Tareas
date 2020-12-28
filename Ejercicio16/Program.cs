using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte el precio sin IVA");
            string n = Console.ReadLine();
            double num = Convert.ToDouble(n);

            const double iva= 21;

            double precio_final = num + num * iva / 100;

            Console.WriteLine("El precio final es {0}",precio_final);
        }
    }
}
