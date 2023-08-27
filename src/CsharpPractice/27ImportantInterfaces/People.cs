using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ImportantInterfaces
{
    public class People : IEnumerable<Person>
    {
        //this one for People
        public IEnumerator<Person> GetEnumerator()
        {
           return new PeopleEnumerator();
        }


        //this one for IEnuremable interface
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
