using System;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            string clave = "c3po";
            int intento = 0;

            while (intento < 3)
            {
                Console.WriteLine("Inserte la contraseña: ");
                string c = Console.ReadLine();

                if (clave == c)
                {
                    Console.WriteLine("Enhorabuena");
                    break;
                }
                else
                {
                    intento++;
                }


            }
        }
    }
}
