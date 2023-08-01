using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Exercicio_de_Fixação.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }



        public double subTotal()
        {
            return Quantity * Product.Price;
        }
        public OrderItem()
        {

        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price.ToString("F2", CultureInfo.InvariantCulture)+", Quantity: "+Quantity; 
        }
    }
}