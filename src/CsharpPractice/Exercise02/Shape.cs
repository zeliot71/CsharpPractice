using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public abstract class Shape
    {
        internal double Height { get; set; }
        internal double Width { get; set; }

        internal abstract void Area();
    }
}
