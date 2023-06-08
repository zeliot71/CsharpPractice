using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18EnumExample
{
    public enum UserStatus
    {
        Verified ,
        Active,
        Blocked,
        Inactive,
        Deleted
            //Specipic vibinno options status hisebe neya hoyeche
    }
    //Onek somoi kono kichur status number & textualy bojhanor  proyojon hoy tokhon enum use kora subidhar

    public enum Gender 
    {
        Male = 'M',
        Female = 'F',
        Other = 'O'
            
    }
    

}
