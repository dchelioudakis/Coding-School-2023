using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringReverse {

        public string? Str;
        public string Reverse() {

            string reversedName;
            StringBuilder mySb = new StringBuilder();

            for (int i = Str.Length - 1; i >= 0; i--) {
                mySb.Append(Str[i]);
            }

            reversedName = mySb.ToString();

            return reversedName;
        }
    }
}