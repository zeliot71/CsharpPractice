using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class RandomNumberGenerator
    {
        private static int _seed;
        private static Random _rand;

        static RandomNumberGenerator()
        {
            _seed = DateTime.Now.Microsecond;
            _rand = new Random(_seed);
        }

        public static int Generate()
        {
            return _rand.Next();
        }
    }
}
