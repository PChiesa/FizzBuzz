using System;

namespace FizzBuzz
{
    class Program
    {
        static NumberValidation numberValidation = new NumberValidation();
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz: Escreva um algoritmo que para números inteiros de 0 até N, imprima “Fizz“ se o i-ésimo número é par, imprima “Buzz” se o i-ésimo número é ímpar e imprima “Fizz Buzz” se o i-ésimo número é múltiplo de 10.");
            bool isValidNumber;
            do
            {
                Console.WriteLine("Escolha o enésimo número:");
                string nString = Console.ReadLine();

                int nNumber;
                isValidNumber = int.TryParse(nString, out nNumber) && nNumber >= 0;

                if (isValidNumber)
                {
                    numberValidation.IterateNumbers(nNumber);
                    Console.ReadKey();
                }
                else
                    Console.WriteLine($"{nString} não é um número ou é menor que 0, tente novamente");

            } while (!isValidNumber);
        }
    }
}
