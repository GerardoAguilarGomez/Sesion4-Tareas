using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();

            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);

            int mayor = Math.Max(num1, num2);

            Console.WriteLine("El número mayor es el {0}", mayor);
        }
    }
}