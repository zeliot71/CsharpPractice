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
        //abstract method: jar asole kono body thakbena, and sorasori etake call o kora jaina
    }
    //echarao abstract class e baki sob normal feilds,property, method and constructor sob applicable
}


//abstract class is a class that contains at least one abstract method. 
//it can contain non-abstract methods as well.

//abstract class can't be instantiated directly but it's child classes can be instantiated.

//when we create an object of abstract class, it will throw error because we have not implemented the abstract method yet.
//we need to implement all the abstract methods in our child classes to avoid this error.

//in c#, you cannot inherit from more than one base class but you can inherit from multiple interfaces and mix them up with base classes as well.