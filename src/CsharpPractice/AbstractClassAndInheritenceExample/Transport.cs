using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInheritenceExample
{
    // Abstract class er khetre duita kotha-
    //(1) eta itself kichuna & nije nije instance create korte parena
    //(2) etar maddhome inherit kore onno class use kora hoi
    //dhora hoye thake ey class ta incomplete eijonno j ey class ta nijeke define korte parena
    abstract class Transport
    {
        public abstract void StartEngine();
        //abstract class e normal method charao amra abstract method declare korte pari, jar asole kono body thakbena

    }
}
