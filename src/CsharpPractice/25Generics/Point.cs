using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Generics
{
    public class Point <T,V,M>
        where T : class , new()
        where V : struct //They are constrain 
        where M : IDisposable
    {//ekhane just placeholder ta likha hoise & caile bar bar vinno vinno data type er jonno eta use kora jabe
        //Ey type T ta only er vitorei kaj korbe
        //generic variables
        public T m;
      

        //generic properties
        public T X { get; set; } 
        public V Y { get; set; }
        public M Z { get; set; }
        

        //Generic method 
        public virtual T Sum(T point)
        {//return type & variables er age data type likha jai
            T t = default(T);
            return t;

        }

        //generic constructor
        public Point(T Oldpoint) //parameter 
        {
            //constructor e <> angle bracet use kora lagena

        }

        public V Multiply<U>(U a)
        {
            throw new NotImplementedException();
        }
    }
    //jokhon kono datar type poristhitir sapekkhe change kora pryojon segulu age thekei class e fixed kore na diye
    // ami segulo ke use korar somoy define korbo


    //override
    //public class advancePoint<R, W, Y> : Point<W, Y, R> where R : class, new()
    //{
    //    public advancePoint(W Oldpoint) : base(Oldpoint)
    //    {
    //    }

    //    public override W Sum(W point)
    //    {
    //        return base.Sum(point);
    //    }
    //}

}
