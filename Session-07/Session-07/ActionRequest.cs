using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionRequest : Action {
        public string Input { get; set; }
        public ActionEnum ActionEnum { get; set; }

        public ActionRequest(string input, ActionEnum actionEnum) {
            RequestID = Guid.NewGuid();
            Input = input;
            ActionEnum = actionEnum;
        }
    }
}
