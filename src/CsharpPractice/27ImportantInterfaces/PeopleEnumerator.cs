using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ImportantInterfaces
{
    internal class PeopleEnumerator : IEnumerator<Person>
    {
        public Person Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

    object IEnumerator.Current
    {
            get
            {
                throw new NotImplementedException();
            }
    }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
