using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInheritenceExample
{
    public class Book : Product
    {
        public string Author { get; set; }
        public Book(string title,uint price) : base(title)
        {
            Prices = price;
        }
        public override string ShortenDescription()
        {
            if(Description.Length > 15)
            {
                return Description.Substring(0,15);
            }
            else
            {
                return Description;
            }
        }

    }
}
