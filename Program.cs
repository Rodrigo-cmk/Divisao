using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {




            double denominador;
            double numerador;
            double resul;

            Console.WriteLine();
            Console.WriteLine("--- Calculadora Divisão ---");
            Console.WriteLine();

            Console.Write("Insira o numerador: ");
            numerador = Convert.ToDouble (Console.ReadLine());

            Console.Write("Insira o denominador: ");
            denominador = Convert.ToDouble (Console.ReadLine());

            if (denominador == 0)
            { 
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ("Atenção! Impossível dividir por zero.");
                Console.ResetColor();
                Environment.Exit(-1);
            }

            resul = numerador / denominador;

            Console.WriteLine();
            Console.Write("O resultado é: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{resul:N2}");
            Console.ResetColor();








        }
    }
}
