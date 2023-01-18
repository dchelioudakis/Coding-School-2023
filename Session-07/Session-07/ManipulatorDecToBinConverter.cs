using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class ManipulatorDecToBinConverter : StringManipulator {
        //CTOR
        public ManipulatorDecToBinConverter() {

        }
        //METHODS
        public override ManipulatorResponse Manipulate(string inputStr) {

            bool success = false;
            string outputStr = string.Empty;

            decimal decimalNum = 0;
            if (Decimal.TryParse(inputStr, out decimalNum)) {

                DecToBinConverter myConverter = new DecToBinConverter(decimalNum);
                
                success = true;
                outputStr = myConverter.Convert();
            }

            return new ManipulatorResponse(success, outputStr);
        }
    }
}
