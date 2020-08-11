using System;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine(" ---- APLICAÇÃO DE VENDAS ---- \n");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Cliente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastro de Clientes");
                        break;
                    case 2:
                        Console.WriteLine("2 - Listar Clientes");
                        break;
                    case 0:
                        Console.WriteLine("Saindo");
                        break;
                    default:
                        Console.WriteLine(" ---- OPÇÃO INVÁLIDA ---- \n");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
