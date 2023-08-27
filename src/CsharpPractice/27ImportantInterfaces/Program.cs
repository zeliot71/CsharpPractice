//Class 15, Time [0:51:30 - 1:10:00]
//IEnuremable: Mainly used to in foreach loop or any types of iteration in linq query

using _27ImportantInterfaces;
using System.Collections;

//ekhane people er method call hoyeche
People people= new People();
people.GetEnumerator();

//ekhane IEnumerable er method call hoyeche
IEnumerable people2 = new People();
people2.GetEnumerator();

foreach(var person in people)
{
    //amra ekhane classes er upor foreach loop use korte pari
}