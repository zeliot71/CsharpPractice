using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloadingExample02
{
    public class Product
    {
        public string Name { get; set; }
        public int Prices { get; set; }
        public int Quantity { get; set; }

        public Product() 
        {
            Name = String.Empty;
            Prices = 0;
            Quantity = 0;
        }

        public Product(string name)
        {
            Name = name;
            Prices= 0;
            Quantity = 0;
        }

        public Product(string name, int price)
        {
            Name = name; 
            Prices = price;
            Quantity = 0;
        }
        public Product(string name,int price,int quantity)
        {
            Name = name; 
            Prices = price;
            Quantity = quantity;
        }


    }
}
