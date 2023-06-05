using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Teacher : Institute
    {
        public string Name { get; set; }
        public DateTime DateOfBirth {get;set;}

        public string GenerateId()
        {
            return "T"+ Name;
        }

        public override void ProgramingClub()
        {
            throw new NotImplementedException();
        }
    }
}
