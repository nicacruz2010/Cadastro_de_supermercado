using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀ █░█ █▀█ █▀▀ █▀█ █▀▄▀█ █▀▀ █▀█ █▀▀ ▄▀█ █▀▄ █▀█
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   ▄█ █▄█ █▀▀ ██▄ █▀▄ █░▀░█ ██▄ █▀▄ █▄▄ █▀█ █▄▀ █▄█");

                Console.ResetColor();
                Console.WriteLine("\n Seja bem vindos ao Supermercado !\n");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n 1 - Produto");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n 2 - Cliente");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n 3 - Funcionario");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n 4 - Fornecedor");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n 5 - Sair");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n Digite a opção escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastroProduto();
                        break;
                    case 2:
                        cadastroCliente();
                        break;
                    case 3:
                        cadastroFuncionario();
                        break;

                    case 4:
                        cadastroFornecedor();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Bye Bye!!!");
                        Thread.Sleep(2000);
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção invalida!!!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;

                }
            }
        }
        static void cadastroProduto()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█ ▄█");

            Console.WriteLine("\n Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("\n Digite o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite a marca do produto: ");
            string marcaProduto = Console.ReadLine();

            Console.WriteLine("\n Digite a categoria do produto: ");
            string categoriaProduto = Console.ReadLine();

        }

        static void cadastroCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀▀ █░░ █ █▀▀ █▄░█ ▀█▀ █▀▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄▄ █▄▄ █ ██▄ █░▀█ ░█░ ██▄");

            Console.WriteLine("\n Digite o nome do Cliente: ");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("\n Digite o endereco do cliente: ");
            string enderecoCliente = Console.ReadLine();

            Console.WriteLine("\n Digite o CPF do cliente: ");
            int CPFcliente = int.Parse(Console.ReadLine());
        }



        static void cadastroFuncionario()

        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀▀ █░█ █▄░█ █▀▀ █ █▀█ █▄░█ ▄▀█ █▀█ █ █▀█
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀░ █▄█ █░▀█ █▄▄ █ █▄█ █░▀█ █▀█ █▀▄ █ █▄█";

            Console.WriteLine("\n Digite o nome do Funcionario: ");
            string nomeFuncionario = Console.ReadLine();

            Console.WriteLine("\n Digite o endereço do Funcionario: ");
            string enderecoFuncionario = Console.ReadLine();

            Console.WriteLine("\n Digite o telefone do Funcionario: ");
            string telefoneFuncionario = Console.ReadLine();


        }
        static void cadastroFornecedor()

        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀▀ █▀█ █▀█ █▄░█ █▀▀ █▀▀ █▀▀ █▀▄ █▀█ █▀█
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀░ █▄█ █▀▄ █░▀█ ██▄ █▄▄ ██▄ █▄▀ █▄█ █▀▄");

            Console.WriteLine("\n Digite o nome do Fornecedor");
            string nomeFornecedor =

            Console.WriteLine("\n Digite o endereco do Fornecedor");
            string enderecoFornecedor =Console.ReadLine();

            Console.WriteLine("\n Digite o telefone do Fornecedor");
            string telefoneFornecedor = Console.ReadLine();
        }
    } 
}