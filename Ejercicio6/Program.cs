using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el valor del producto");
            string precio = Console.ReadLine();

            Console.WriteLine("Elija metodo de pago: Efectivo o Tarjeta");
            string forma_pago = Console.ReadLine();

            if (forma_pago == "Tarjeta")
            {
                Console.WriteLine("Inserte número de tarjeta");

                string num_tarjeta = Console.ReadLine();

            }
        }
    }
}
