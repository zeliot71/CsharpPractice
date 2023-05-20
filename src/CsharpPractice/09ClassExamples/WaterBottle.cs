using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09ClassExamples
{
    class WaterBottle
    {
        //variables
        private double _capacity;
        string _color;
        private double waterAmount;

        //property
        //property is another kinda variable. the benifits of property is setting logic. we can set logic,set constant value while declaring and give access as we want

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
        //auto property
        public string Color { get; set; } 
        public double amounts { get; private set; }

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
        public void addWater(double amount)
        {
            waterAmount += amount;
        }

        public void AddWater(int amount, bool checkOverflow)
        {
            if(checkOverflow)
            {
                if(amount+waterAmount> Capacity) 
                {
                    waterAmount += amount;
                }
            }
        }
    }

}
