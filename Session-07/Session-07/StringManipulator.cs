using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringManipulator {
        public string? InputStr { get; set; }
        public virtual ManipulatorResponse Manipulate() {
            bool success = false;
            string outputStr = string.Empty;

            return new ManipulatorResponse(success, outputStr);
        }
    }
}
