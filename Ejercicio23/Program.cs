using System;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta el primer operador: ");
            string v1 = Console.ReadLine();
            double operador1 = Convert.ToDouble(v1);


            Console.WriteLine("Inserta el segundo operador: ");
            string v2 = Console.ReadLine();
            double operador2 = Convert.ToDouble(v2);

            Console.WriteLine("Indica el símbolo de la operación que deseas (+,-,*,/,%): ");
            string simbolo = Console.ReadLine();

            double resultado = 0;

            switch (simbolo)
            {
                case "+":
                    resultado = operador1 + operador2;
                    break;
                case "-":
                    resultado = operador1 - operador2;
                    break;
                case "*":
                    resultado = operador1 * operador2;
                    break;
                case "/":
                    resultado = operador1 / operador2;
                    break;
                case "%":
                    resultado = operador1 % operador2;
                    break;

            }
            Console.WriteLine(resultado);
        }
    }
}
