using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise03
{
    public class StringUtils
    {

        public string Reverse(string string1)
        {
            char[] newString = string1.ToCharArray();
            Array.Reverse(newString);
            string reversedString = new string(newString);
            return reversedString;
        }
         public string[] Reverse(string[] inputArray)
        {
            string[] reversedArray = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                reversedArray[i] = Reverse(inputArray[i]);
            }
            return reversedArray;
        }

    }
}
