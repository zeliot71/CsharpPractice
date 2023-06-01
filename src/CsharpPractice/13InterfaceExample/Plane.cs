using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13InterfaceExample
{
    internal class Plane : ITransport, IFlyable
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            Console.WriteLine("Landing plane!");
        }
    }
}
