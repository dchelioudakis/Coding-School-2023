using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class DecToBinConverter {
        //PROPERTIES
        public decimal? ToBeConverted;

        //CTOR
        public DecToBinConverter(decimal toBeConverted) {
            ToBeConverted = toBeConverted;
        }
        //METHODS
        public string Convert() {
            //Take a decimal and return it converted to binary.
            StringBuilder mySb = new StringBuilder();

            for (int i = 0; ToBeConverted > 0; i++) {
                mySb.Clear();
                mySb.Insert(0, ToBeConverted % 2);
            }

            return mySb.ToString();
        }
    }
}
