using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ExampleOFstatic
{
    public static class EmailUtility
    {
        //Static er khetre duita kotha mone rakhte hobe-
        //(1) static class er vitor feild,property,variables, constructor and methods sob static hote hobe
        //(2) Non static class er vitor o static variables likha jai

        public static int count;
        //static variable
        public static string Subject { get; set; }
        //static property

        public static void SendEmail(string name, string email,string subject,string body)
        {
        //static method
            
        }

        static EmailUtility()
        {
        //static constructor er khetre access modifier use kora jaina

        }


    }
}
