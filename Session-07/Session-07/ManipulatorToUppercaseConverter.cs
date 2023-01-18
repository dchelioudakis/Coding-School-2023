using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class ManipulatorToUppercaseConverter : StringManipulator{
        //CTOR
        public ManipulatorToUppercaseConverter(string inputStr) {
            InputStr = inputStr;
        }
        //METHODS
        public override ManipulatorResponse Manipulate() {

            bool success = false;
            string outputStr = string.Empty;

            if (Regex.IsMatch(InputStr, "^[a-zA-Z ]+$")) {
                string longestWord = new PhraseLongestWord(InputStr).Get();

                success = true;
                outputStr = longestWord.ToUpper();
            }
            
            return new ManipulatorResponse(success, outputStr);
        }
    }
}
