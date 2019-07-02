using System;
using System.Collections.Generic;

namespace Exercicio2
{
    internal class Program
    {
        static public float MediaDosValores(List<float> valores)
        {
            float media = 0;
            for (int i = 0; i < valores.Count; i++)
            {
                media += valores[i];
            }

            return media / valores.Count;
        }

        private static void Main(string[] args)
        {
            List<float> listaNumeros = new List<float>();
            Console.WriteLine("Digite quantos numeros positivos quiser, digite 0 quando acabar de digitar o conjunto");
            Console.WriteLine("Será mostrado dados sobre esse conjunto");

            float val = -1;

            while (val != 0)
            {
                val = (float)Convert.ToDouble(Console.ReadLine());
                if (val > 0)
                {
                    listaNumeros.Add(val);
                }
                else if (val < 0)
                {
                    Console.WriteLine("Inválido, numero negativo");
                }
            }

            List<float> listaPares = listaNumeros.FindAll(x => x % 2 == 0);
            int qtdImpares = listaNumeros.FindAll(x => x % 2 != 0).Count;

            Console.WriteLine("-----------");
            Console.WriteLine("Quantidade de Pares: " + listaPares.Count);
            Console.WriteLine("Quantidade de Impares: " + qtdImpares);
            Console.WriteLine("Media dos valores Pares: " + MediaDosValores(listaPares));
            Console.WriteLine("Media geral: " + MediaDosValores(listaNumeros));

            Console.ReadKey();
        }
    }
}