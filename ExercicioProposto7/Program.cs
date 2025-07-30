using System;

namespace ExercicioProposto7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("O número é negativo !");
            }
            else if (n == 0) {
                Console.WriteLine("O número é 0");
            }
            else
            {
                Console.WriteLine("O número é positivo !");
            }
        }
    }
}