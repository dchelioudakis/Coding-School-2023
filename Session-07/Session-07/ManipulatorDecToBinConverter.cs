using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class ManipulatorDecToBinConverter : StringManipulator {
        //CTOR
        public ManipulatorDecToBinConverter(string inputStr) {
            InputStr = inputStr;
        }
        //METHODS
        public override ManipulatorResponse Manipulate() {

            bool success = false;
            string outputStr = string.Empty;

            decimal decimalNum = 0;
            if (Decimal.TryParse(InputStr, out decimalNum)) {
                success = true;
                outputStr = ConvertToBinary(decimalNum);
            }

            return new ManipulatorResponse(success, outputStr);
        }

        public string ConvertToBinary(decimal toBeConverted) {
            //Take a decimal and return it converted to binary.
            StringBuilder mySb = new StringBuilder();

            for (int i = 0; toBeConverted > 0; i++) {
                mySb.Clear();
                mySb.Insert(0, toBeConverted % 2);
            }

            return mySb.ToString();
        }
    }
}
