using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ManipulatorResponse {
        // PROPERTIES
        public string OutputStr { get; set; }
        public bool Success { get; set; }

        //CTOR
        public ManipulatorResponse(bool success, string outputStr) {
            OutputStr = outputStr;
            Success = success;
        }
    }
}
