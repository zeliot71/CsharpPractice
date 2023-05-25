using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10InheritenceExample
{
    //ekhane PRODUCT class er child hocche BOOK ejjono PRODUCT (parent) class hote tar properties pabe inheritence wise
    public class Book : Product
    {
        public string Author { get; set; } 
    }
}
