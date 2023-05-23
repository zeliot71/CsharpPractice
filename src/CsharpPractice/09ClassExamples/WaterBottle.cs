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

        //Method & Method Overloading
        //C# e method er khetre 2 ta kotha mone rakhben (1) obosshoi return type thakte hobe (2) method ekbar call korben r bar bar call kore use korben
        public void addWater(int amount)
        {
            waterAmount += amount;
        }
        //method overloading
        public void addWater(double amount)
        {
            waterAmount += amount;
        }

        //Constructor & Constructor Overloading
        //constructor er khetre 2 ta kotha mone rakhben, 1- class er name hobe 2- apni constructor na likhleo ekta default vabe thake

        public WaterBottle()
        {
            Capacity= 100;
            Color = "red";
        }
        //overloading- er khetre 2 ta kotha mone rakhben: (1) overloading er maddhome multiple constructor lekha jai (2) obosshoi constructor gular paramiter defferent hote hobe
        public WaterBottle(double capacity, string color)
        {
            Capacity= capacity;
            Color= color;
        }
    }
}
