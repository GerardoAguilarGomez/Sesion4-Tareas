using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            int n2 = 3;

            if (n1 > n2)
            {
                Console.WriteLine("El número {0} es mayor que el {1}", n1, n2);
            }
            else if (n2>n1)
            {
                Console.WriteLine("El número {0} es mayor que el {1}", n2, n1);

            }
            else
            {

                Console.WriteLine("Los números son iguales");
            }
        }
    }
}
