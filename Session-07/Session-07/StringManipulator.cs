using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringManipulator {
        public string? InputStr { get; set; }
        public virtual ManipulatorResponse Manipulate(string inputStr) {
            bool success = false;

            return new ManipulatorResponse(success, inputStr);
        }
    }
}
