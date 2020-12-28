using System;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un día de la semana: ");
            string dia = Console.ReadLine();

            switch (dia)
            {


                case "lunes":
                    Console.WriteLine("Laborable");
                    break;
                case "martes":
                    Console.WriteLine("Laborable");
                    break;
                case "miercoles":
                    Console.WriteLine("Laborable");
                    break;
                case "jueves":
                    Console.WriteLine("Laborable");
                    break;
                case "viernes":
                    Console.WriteLine("Laborable");
                    break;
                case "sabado":
                    Console.WriteLine("Festivo");
                    break;
                case "domingo":
                    Console.WriteLine("Festivo");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
