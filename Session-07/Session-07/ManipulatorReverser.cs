using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class ManipulatorReverser : StringManipulator {
        //CTOR
        public ManipulatorReverser(string inputStr) {
            InputStr = inputStr;
        }
        //METHODS
        public override ManipulatorResponse Manipulate() {

            bool success = false;
            string outputStr = string.Empty;

            if (Regex.IsMatch(InputStr, "^[a-zA-Z]+$")) {
                outputStr = Reverse(InputStr);
                success = true;
            }

            return new ManipulatorResponse(success, outputStr);
        }

        public string Reverse(string toBeReversed) {
            //Take a string and return it reversed.
            StringBuilder mySb = new StringBuilder();

            for (int i = toBeReversed.Length - 1; i >= 0; i--) {
                mySb.Append(toBeReversed[i]);
            }

            return mySb.ToString();
        }
    }
}
