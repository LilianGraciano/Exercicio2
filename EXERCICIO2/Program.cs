using System;

namespace EXERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para consultar se ele faz parte da sequência de Fibonacci.:\n ");
            int num = int.Parse(Console.ReadLine());

            bool pertence = ConsultarFibonacci(num);

            if (pertence)
            {
                Console.WriteLine($"O número digitado {num} pertence a sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número digitado {num} não pertence a sequência de Fibonacci.");
            }
        }

        static bool ConsultarFibonacci(int num)
        {
            int a = 0;
            int b = 1;
            while (b <= num)
            {
                if (b == num)
                {
                    return true;
                }
                int temp = a;
                a = b;
                b = temp + b;
            }
            return false;
        }
    }
}