using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10InheritenceExample
{
    //ekhane PRODUCT class er child hocche ELECTRONICS ejjono electronics class product(parent) class hote tar properties inheritence wise pabe
    public class Electronics : Product
    {
        public string Model { get; set; }
    }
}
