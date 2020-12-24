using System;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta numero de ventas:");
            string n = Console.ReadLine();
            int n_v = Convert.ToInt32(n);

            int suma=0;
            int cont = 0;

            while (cont < n_v)
            {

                Console.WriteLine("Valor de la venta: ");
                string valor = Console.ReadLine();
                int v = Convert.ToInt32(valor);

                suma = suma + v;

                cont++;

            }

            Console.WriteLine("La suma total de todas las ventas es {0}", suma);
        }
    }
}
