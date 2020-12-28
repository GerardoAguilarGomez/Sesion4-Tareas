using System;

namespace Ejercicio5
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
                    Console.WriteLine("No es fin de semana");
                    break;
                case "martes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "miercoles":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "jueves":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "viernes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "sabado":
                    Console.WriteLine("Si es fin de semana");
                    break;
                case "domingo":
                    Console.WriteLine("Si es fin de semana");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
