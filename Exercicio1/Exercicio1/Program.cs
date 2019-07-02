using System;

namespace Exercicio1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int count = 0;
            Console.WriteLine("Digite 5 valores para saber quais são negativos");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] < 0) count++;
            }

            Console.WriteLine("Existem " + count + " numeros negativos, são eles:");

            foreach (int num in numeros)
            {
                if (num < 0) Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}