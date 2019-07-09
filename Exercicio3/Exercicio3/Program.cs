using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Fique digitando a quantidade de gold seguida da quantidade de montarias dos personagens");
            Console.WriteLine("Digite uma quantidade negativa de gold quando quiser parar de digitar personagens");

            //variaveis para guardar e calcular os valores 
            float maiorGold, mediaGold, mediaMontaria, percentualGold, quantidadePersonagens;

            float val = 0;
            quantidadePersonagens = maiorGold = mediaGold = mediaMontaria = percentualGold = 0;

            while (val >= 0)
            {
                val = (float)Convert.ToDouble(Console.ReadLine());


                //gold
                if (val > 0)
                {
                    if (val > maiorGold) maiorGold = val;
                    mediaGold += val;

                    if (val <= 100) percentualGold++;

                }
                else if (val < 0)
                {

                    break;
                }

                val = (float) Convert.ToInt32(Console.ReadLine());

                //montaria
                if (val > 0)
                {
                    
                    mediaMontaria += val;
                }
                else if (val < 0)
                {
                    Console.WriteLine("Inválido, numero negativo de montaria");
                    
                }


                quantidadePersonagens++;
            }

            Console.WriteLine("-----------");
            Console.WriteLine("Média de Gold: " + mediaGold / quantidadePersonagens);
            Console.WriteLine("Média de Montarias: " + mediaMontaria / quantidadePersonagens);
            Console.WriteLine("Maior Gold: " + maiorGold);
            Console.WriteLine("% de Personagens com até 100G: " + percentualGold / quantidadePersonagens * 100 + "%");


            Console.ReadKey();
        }
    }
}
