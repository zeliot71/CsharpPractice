using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10InheritenceExample
{
    //ekhane ELECTRONICS class er child hocche CAMERA ejjono ELECTRONICS class(parent) hote tar properties inheritence wise pabe
    public class Camera : Electronics
    {
        public double ZoomCapacity { get; set; }
        

    }
}
