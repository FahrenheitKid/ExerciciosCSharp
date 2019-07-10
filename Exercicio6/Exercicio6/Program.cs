using System;

namespace Exercicio6
{
    internal class Calculadora
    {
        static public double Soma(double a, double b)
        {
            return a + b;
        }

        static public double Subtracao(double a, double b)
        {
            return a - b;
        }

        static public double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        static public double Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro, divisão por zero");
                return 0;
            }
            else return a / b;
        }
    }

    internal class CalculadoraCientifica : Calculadora
    {
        static public double RaizQuadrada(double a)
        {
            return Math.Sqrt(a);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            double opcao = -1;
            bool sair = false;
            bool calcCientifica = false;

            
            while (!sair)
            {
                Console.WriteLine("Digite qual calculadora deseja utilizar:");
                Console.WriteLine("1 - Calculadora Básica");
                Console.WriteLine("2 - Calculadora Científica");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToDouble(Console.ReadLine());
                if (opcao == 0)
                {
                    sair = true;
                    break;
                }
                else if (opcao == 1 || opcao == 2)
                {
                    Console.WriteLine("Digite qual operacao deseja utilizar:");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    if (opcao == 2)
                    {
                        calcCientifica = true;
                        Console.WriteLine("5 - Raiz");
                    }
                    else calcCientifica = false;
                    Console.WriteLine("0 - Voltar");

                    opcao = Convert.ToDouble(Console.ReadLine());

                    if (!calcCientifica)
                    {
                        while (opcao != 0 && opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4)
                        {
                            Console.WriteLine("Opção inválida, digite novamente");
                            opcao = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    else
                    {
                        while (opcao != 0 && opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 5)
                        {
                            Console.WriteLine("Opção inválida, digite novamente");
                            opcao = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                    if (opcao != 0)
                    {
                        double a = 1;
                        double b = 1;
                        if (opcao != 5)
                        {
                            Console.WriteLine("Digite a seguir os 2 numeros para realizar a operação:");
                            a = Convert.ToDouble(Console.ReadLine());
                            b = Convert.ToDouble(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Digite a seguir o numero para realizar a operação:");
                            a = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("=======================");
                        Console.WriteLine("");
                        Console.WriteLine("=======================");
                        switch (opcao)
                        {
                            case 1:
                                Console.WriteLine("Resposta: " + a + " + "+ b + " = " + CalculadoraCientifica.Soma(a, b));
                                break;

                            case 2:
                                Console.WriteLine("Resposta: " + a + " - " + b + " = " + CalculadoraCientifica.Subtracao(a, b));

                                break;

                            case 3:
                                Console.WriteLine("Resposta: " + a + " * " + b + " = " + CalculadoraCientifica.Multiplicacao(a, b));

                                break;

                            case 4:
                                Console.WriteLine("Resposta: " + a + " / " + b + " = " + CalculadoraCientifica.Divisao(a, b));

                                break;

                            case 5:
                                Console.WriteLine("Resposta: A raiz quadradada de " + a + " = " + CalculadoraCientifica.RaizQuadrada(a));

                                break;
                        }

                        Console.WriteLine("=======================");
                        Console.WriteLine("");
                        Console.WriteLine("=======================");
                    }
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }

            }

            //Console.ReadKey();
        }
    }
}