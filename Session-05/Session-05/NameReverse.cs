using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{   //1. Write a C# program that reverses a given string (your name).
    public class NameReverse
    {
        public string Reverse()
        {
            string name = "Dimitris";
            string reversedName;
            StringBuilder mySb = new StringBuilder();

            for (int i = name.Length-1; i >= 0; i--)
            {
                mySb.Append(name[i]);
            }

            reversedName = mySb.ToString();
            
            return reversedName;
        }
    }
}
