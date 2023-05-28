using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInheritenceExample
{
    public class Product
    {
        protected string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public uint Prices { get; set; }
        public Product() { }

        public Product(string title) 
        {
            Title= title;
        }


        public virtual string ShortenDescription() 
        {
            if(Description.Length > 20)
            {
                return Description.Substring(0, 20);
            }
            else
            {
                return Description;
            }

        }



    }
}
