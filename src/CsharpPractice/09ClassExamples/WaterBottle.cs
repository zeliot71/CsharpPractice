using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09ClassExamples
{
    class WaterBottle
    {
        private double _capacity;
        string _color;
        private double waterAmount;

        //property
        public double Capacity 
        {

            get
            {
                if (Capacity < 0)
                    return 100;
                else
                    return Capacity;
            }
            set
            {
                if(_capacity< 6000)
                {
                    _capacity = value;
                }
            }
        }
        public string Color { get; set; } 

        //constructor
        public WaterBottle(double capacity, string color)
        {
            _capacity = capacity;
            _color = color;
        }

        //Method
        public void addWater(int amount)
        {
            waterAmount += amount;
        }
    }
}
