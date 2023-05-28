using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace _09ClassExamples
{
    class WaterBottle
    {
        private double _capacity;
        string _color;
        private double waterAmount;
        private readonly string _material= "Plastic";
        //readonly variable can only declare while writing it and into the constructor
        private const string deameter = "3.1416";
        //constant variable only likhar somoy declare kora jai
        private List<string> _icons = new List<string>();
        //collection er memory destroy korar jonno ache Destructor or Finalizer

        ~WaterBottle()
        {
            _icons.Clear();
            _icons = null;
            //Ey sei bikkhato destructor ja khub kom use kora hoi c# e
            //karon default vabe ekta gurbage collector thake ja memory clear kore  
        }

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
            addWater(amount);
            //we can call any method into another method.
            waterAmount += amount;
        }

        //Constructor & Constructor Overloading
        //constructor er khetre 2 ta kotha mone rakhben, 1- class er name hobe 2- apni constructor na likhleo ekta default vabe thake
        //we can't call a constructor into another constractor so that constructor chainning came
        public WaterBottle() : this(200, "green")
        {
            Capacity= 100;
            Color = "red";
        }
        //overloading- er khetre 2 ta kotha mone rakhben: (1) overloading er maddhome multiple constructor same name lekha jai (2) obosshoi constructor gular paramiter er data type or quantity defferent hote hobe
        public WaterBottle(double capacity, string color)
        {
            Capacity= capacity;
            Color= color;
        }
    }
}
