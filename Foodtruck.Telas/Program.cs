using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Telas
{
    /*
     * O dono de um foodtruck deseja criar um sistema 
     * para gerenciar seus clientes, controlar suas 
     * vendas e oferecer um programa de fidelidade

O sistema deve permitir:
Cadastrar os clientes (CPF, Nome e Email)
Cadastrar os lanches do cardápio (código, nome e valor)
Cadastrar as bebidas do cardápio (código, nome, valor, tamanho (em ml))
Cadastrar os pedidos. O pedido deve ter:
Data da compra
Cliente
Lanches
Bebidas
Valor total
Mostrar um relatório com o CPF, nome do cliente, quantidade de lanches comprados e total gasto por cliente.

    */
    class Program
    {
        static Gerenciador gerenciador = new Gerenciador();

        static void Main(string[] args)
        {
            
            int opcao = 0;
            do
            {
                Console.WriteLine("======= FOODTRUCK MANAGER =======");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0: break;
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    default: Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }

        public static void AdicionarCliente()
        {
            Console.Clear();
            Cliente novoCliente = new Cliente();
            Console.WriteLine("Informe o código:");
            novoCliente.Id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Informe o CPF:");
            novoCliente.CPF = Console.ReadLine();

            Console.WriteLine("Informe o nome:");
            novoCliente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o email:");
            novoCliente.Email = Console.ReadLine();

            Validacao validacao = gerenciador.AdicionarCliente(novoCliente);
            if (validacao.Valido)
            {
                Console.WriteLine("Cliente cadastrado com sucesso!");
            }
            else
            {
                foreach(String key in validacao.Mensagens.Keys)
                {
                    String mensagem = validacao.Mensagens[key];
                    Console.WriteLine($"{key}: {mensagem}");
                }
            }
            Console.ReadLine();
        }

        public static void ListarClientes()
        {
            List<Cliente> clientesCadastrados = gerenciador.TodosOsClientes();
            foreach(Cliente cliente in clientesCadastrados)
            {
                Console.WriteLine(cliente.Descrever());
            }
        }
    }
}
