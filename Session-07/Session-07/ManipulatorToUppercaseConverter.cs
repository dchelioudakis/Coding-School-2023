using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class ManipulatorToUppercaseConverter : StringManipulator{
        //CTOR
        public ManipulatorToUppercaseConverter() {

        }
        //METHODS
        public override ManipulatorResponse Manipulate(string inputStr) {

            bool success = false;
            string outputStr = string.Empty;

            if (Regex.IsMatch(inputStr, "^[a-zA-Z ]+$")) {
                
                actionResponse.Output = longestWord.ToUpper();
            }
            else {
                actionResponse.Output = "Not valid string";
            }

            return new ManipulatorResponse(success, outputStr);
        }
    }
}
