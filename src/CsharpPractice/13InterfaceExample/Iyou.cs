using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13InterfaceExample
{
    public interface Iyou //this is the interface declaration 
                            //methods and properties must be defined inside the brackets of the interface declaration
    {
        //interface is a contract that defines what methods an object should have.
        //we can use interface in the same way as we use classes but they are not classes, they are just contracts.
        //they cannot be instantiated and only used to define other objects.
        //interfaces can inherit from each other, but interfaces cannot inherit from class or structs.



        void MyMethod();       //this method does not need any parameters because it's empty (void means no return value)

            int MyProperty { get; set; }      //this property has both a getter and setter so it has two accessors (get/set)

            string Name { get; set; }          //you can also define properties without accessors by using this syntax: "string Name;" instead of "string Name { get; set;}".
                                               //This is called auto-properties. They don't require you to specify their type like you do with fields or properties with custom accessors,
                                               //which makes them more concise when defining multiple members on one line. Auto-properties are readonly by default, so you need to add a keyword "readonly" after
                                               //your property name if you want it to be writable (like normal properties). If your property will never change its value once assigned, then there's no need for a writeable version of it at all!
                                               //It's usually best practice to make all auto-properties readonly unless absolutely necessary! You'll see examples below of how this works in C# 6+ later on in this course!

        }
    }
}
