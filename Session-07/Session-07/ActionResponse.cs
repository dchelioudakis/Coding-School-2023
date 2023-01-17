using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResponse : Action {
        public Guid ReponseID { get; set; }
        public string Output { get; set; }

        public ActionResponse() {
            RequestID = Guid.NewGuid();
        }
    }
}
