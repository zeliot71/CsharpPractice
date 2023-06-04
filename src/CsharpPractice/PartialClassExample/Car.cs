using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    public partial class Car
    {
        //Partial er khetre dui kotah-
        //1. er maddhome ekta class'k vinno vinno file e rakha jai
        //2. program.cs file e er sob class er feild properties pawa jabe
        protected string _model;
        public Car(string model) 
        {
            _model= model;
        }
        public void Start()
        {
            Console.WriteLine("Starting Car");
        }
    }
}
