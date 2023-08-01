using Exercicio_de_Fixação.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Exercicio_de_Fixação.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client client { get; set; }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
             Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
              total += item.subTotal();
            }
            return total;
        }

        public Order()
        {

        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            this.client = client;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("ORDER SUMARY:");
            s.AppendLine("Order moment: "+Date.ToString("dd/MM/yyyy HH:mm:ss"));
            s.AppendLine("Order status: " + Status);
            s.AppendLine(client.ToString());
            s.AppendLine("Order items:");

            foreach(OrderItem item in Items)
            {
                s.AppendLine(item.ToString());
            }

            s.AppendLine("Total price: $"+Total().ToString("F2", CultureInfo.InvariantCulture));

            return s.ToString();   
        }
    }
}
