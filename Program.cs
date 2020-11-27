using System;

namespace Aula_27_11
{
    class Program
    {
        static void Main(string[] args)
        {



            //Declarar Variavel
            // bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;

            string[] nome = new string[3];
            float[] preco = new float[3];
            bool[] promocao = new bool[3];
            string [] respostaPromocao = new string[3];

            //Dados da passagem

            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("---- Sistema de Produtos ----");
            Console.WriteLine("-----------------------------");

            //Login
            // do
            // {
            //     Console.WriteLine("Digite a senha para acessar o sistema");
            //     string senha = Console.ReadLine();
            //     senhaValida = EfetuarLogin(senha);
            // } while (!senhaValida);

            //Menu

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
                                Console.Write($"Digite o nome do {contador + 1}º produto: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                nome[contador] = Console.ReadLine();
                                Console.ResetColor();

                                Console.Write($"Digite o preco do {contador + 1}º produto: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                preco[contador] = float.Parse(Console.ReadLine());
                                Console.ResetColor();

                                Console.Write($"O produto {contador + 1}º está em promoção? ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                string r = (Console.ReadLine());
                                if (r == "Sim")
                                {
                                    return true;
                                }
                                else
                                {
                                   return false; 
                                }
                                Console.ResetColor();

                                contador++;
                                Console.WriteLine("Você gostaria de cadastrar um novo produto? S/N");
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
                            Console.Write($"Nome: {nome[contador]}\nPreco: {preco[contador]}\nProduto em promocao: {promocao[contador]}");

                        }
                        break;
                    default:

                        break;
                }

            } while (escolha != 0);

            //Função
            // bool EfetuarLogin(string senha)
            // {
            //     if (senha == "123456")
            //     {
            //         Console.WriteLine("Senha Válida");
            //         return true;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Senha Inválida");
            //         return false;
            //     }

            // }
        }
    }

}
