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

                StringReverser myReverse = new StringReverser(InputStr);

                outputStr = myReverse.Reverse();
                success = true;
            }

            return new ManipulatorResponse(success, outputStr);
        }
    }
}
