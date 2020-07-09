using CadastroEVA_001.Entities;
using CadastroEVA_001.Entities.Enums;
using System;
using System.Globalization;

namespace CadastroEVA_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //char continuar = 'S';
            //double carrinho = 0.0;
            DateTime dtMoment;

            
            Console.WriteLine("Entre com o nome do cliente:");
            string nmClient = Console.ReadLine();
            Console.WriteLine("Entre com os dados do Pedido:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("Quantos itens deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());

            dtMoment = DateTime.Now;

            Client cli = new Client(nmClient);
            //associando entrada
            Order order = new Order(dtMoment, status, cli);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com o #{i} item:");
               
                    Console.WriteLine("Escolha o produto:");
                    Console.WriteLine("(1) Rosa Monique" + "\n"
                                    + "(2) Sepala Pequena" + "\n"
                                    + "(3) Folha de Rosa Grande" + "\n"
                                    + "(4) Flor Desidratada" + "\n"
                                    + "(5) Arame" + "\n"
                                    + "(6) Vaso de Vidro" + "\n"
                                    + "(7) Fita Floral");
                    int idProduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com a quantidade:");
                    int qtProduto = int.Parse(Console.ReadLine());

                    Product product = new Product(idProduto, qtProduto);

                    //Instancia a classe OrderItem passando o Id do produto e sua quantidade
                    OrderItem items = new OrderItem(idProduto, qtProduto, product);
                    order.AddItem(items); //adiciona no pedido 
            }
            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO:");
            Console.WriteLine(order);
        }
    }
}
