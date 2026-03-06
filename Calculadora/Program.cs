using System;

namespace CalculadoraCheckpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string Opcao;

            // Estrutura de repetição para o programa continuar executando (Requisito 5)
            do
            {
                Console.Clear();
                Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Adição");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Multiplicação");
                Console.WriteLine("4-Divisão");
                Console.WriteLine("5-Sair");
                Console.Write("\nDigite sua opção: ");

                Opcao = Console.ReadLine();

                if (Opcao == "5") break; // Encerra o loop

                // Verifica se a opção é válida antes de pedir os números
                if (Opcao == "1" || Opcao == "2" || Opcao == "3" || Opcao == "4")
                {
                    // Uso de double para permitir números decimais (Requisito 4 pts - Tipos de dados)
                    Console.Write("Digite o primeiro número: ");
                    double NumeroUm = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double NumeroDois = double.Parse(Console.ReadLine());

                    double Resultado = 0;
                    bool OperacaoValida = true;

                    // Estrutura de controle Switch (Requisito 4 pts)
                    switch (Opcao)
                    {
                        case "1":
                            Resultado = NumeroUm + NumeroDois;
                            break;
                        case "2":
                            Resultado = NumeroUm - NumeroDois;
                            break;
                        case "3":
                            Resultado = NumeroUm * NumeroDois;
                            break;
                        case "4":
                            // Tratamento de erro: Divisão por zero (Requisito 6)
                            if (NumeroDois != 0)
                            {
                                Resultado = NumeroUm / NumeroDois;
                            }
                            else
                            {
                                Console.WriteLine("\nErro: Não é possível dividir por zero!");
                                OperacaoValida = false;
                            }
                            break;
                    }

                    if (OperacaoValida)
                    {
                        Console.WriteLine($"\nO resultado da operação é: {Resultado}");
                    }
                }
                else
                {
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (Opcao != "5");

            Console.WriteLine("Programa encerrado. Até logo!");
        }
    }
}