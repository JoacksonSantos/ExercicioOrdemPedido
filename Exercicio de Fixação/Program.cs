using Exercicio_de_Fixação.Entities;
using Exercicio_de_Fixação.Entities.Enums;

namespace Exercicio_de_Fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name,email, date);
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status =  Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order ?");
            int quantityItens = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now,status,client);
            for(int i = 0; i < quantityItens; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: " );
                string nameItem = Console.ReadLine();
                Console.Write("Product price: ");
                double priceItem = Double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int itemQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameItem,priceItem);
                OrderItem orderItem = new OrderItem(product,itemQuantity);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine(order.ToString());

            



        }
    }
}