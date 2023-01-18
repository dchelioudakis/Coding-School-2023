using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringReverser : StringManipulator {

        public StringReverser() {

        }
        public override ManipulatorResponse Manipulate(string inputStr) {

            bool success = false;
            string outputStr = string.Empty;

            if (Regex.IsMatch(inputStr, "^[a-zA-Z]+$")) {

                StringReverse myReverse = new StringReverse();
                myReverse.Str = inputStr;

                outputStr = myReverse.Reverse();
                success = true;
            }
            

            return new ManipulatorResponse(success, outputStr);
        }
    }
}
