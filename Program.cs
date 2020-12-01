using System;

namespace Aula_27_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            int contador = 0;
            string resposta;

            string[] produto = new string[3];
            float[] preco = new float[3];
            bool[] promocao = new bool[3];

            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("---- Sistema de Produtos ----");
            Console.WriteLine("-----------------------------");

            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("[1] - Cadastrar Produto");
                Console.WriteLine("[2] - Listar Produtos");
                Console.WriteLine("[3] - Mostrar Menu");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {

                    case 1:
                        Console.WriteLine("Cadastrar Produto");
                        do
                        {
                            if(contador < 2 ){
                            Console.WriteLine($"Digite o nome do {contador+1}º produto");
                            produto[contador] = Console.ReadLine();

                            Console.WriteLine($"Digite o preço do {contador+1} produto");
                            preco [contador] = float.Parse(Console.ReadLine());

                            Console.WriteLine($"Este produto está na promoção? (true/false) ");
                            promocao [contador] = bool.Parse(Console.ReadLine());

                            contador++;

                            }else
                            {
                                Console.WriteLine("O limite de produtos que você pode cadastrar foi excedido");
                                break;
                            }    
                            Console.WriteLine("Gostaria de Cadastrar mais produtos ? S/N");
                            resposta = Console.ReadLine().ToUpper();
                        } while (resposta == "S");
                        break;
                    case 2:
                        Console.WriteLine("Lista de produtos cadastrados: ");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"PASSAGEM {i + 1}");
                            Console.ResetColor();
                            Console.WriteLine($"Nome: {produto[i]}");
                            Console.WriteLine($"Preco: {preco[i]}");
                            Console.WriteLine($"Produto em promocao: {promocao[i]}\n");

                        }
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");

                        break;
                }

            } while (escolha != 0);
        }
    }

}
