using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

    public enum ActionEnum {
        Convert,
        Uppercase,
        Reverse
    }

    public class Message {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Msg { get; set; }
    }

    public class MessageLogger {
        public Message[] Messages { get; set; }

        //CTOR

        //METHODS
        public void ReadAll() {

        }
        public void Clear() {

        }
        public void Write(Message message) {
        
        }
    }

    public class Action {
        public Guid RequestID { get; set; }

        public Action() {
            RequestID = Guid.NewGuid();
        }

    }
    public class ActionRequest : Action {
        public string Input { get; set; }
        public ActionEnum ActionEnum { get; set; }
    }

    public class ActionResponse : Action {
        public Guid ReponseID { get; set; }
        public string Output { get; set; }
    }

    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver() {

        }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {


            return null;
        }


    }
}
