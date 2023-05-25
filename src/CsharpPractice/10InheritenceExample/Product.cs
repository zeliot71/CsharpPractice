using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10InheritenceExample
{
    public class Product
    {
        public int Id { get; set; }
        //public variables everywhere in this project access kora jai and onno project eo!
        public string Name { get; set; }
        private string Barcode { get; set; }
        //private variables ey class chara onno kono class e access kora jabena
        protected string Coupon { get; set; }
        //protected variables ey class and child classes e access kora jai
        internal string Description { get; set; }
        //internal only ey project er vitor access kora jai
    }
}
