using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Message(string msg) {
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            Msg = msg;
        }
    }

    public class MessageLogger {
        public Message[]? Messages { get; set; }

        //CTOR
        public MessageLogger() {
            Messages = new Message[1000];
        }
        //METHODS
        public void ReadAll() {
            foreach (var message in Messages) {
                Console.WriteLine(message.Msg);
            }
        }
        public void Clear() {
            for (int i = 0; i < Messages.Length; i++) {
                if (Messages[i] != null) {
                    Messages[i] = null;
                }
            }
        }
        public void Write(Message message) {
            for (int i = 0; i < Messages.Length; i++) {
                if (Messages[i] != null) {
                    Messages[i] = message;
                }
            }
        }
    }

    public class Action {
        public Guid RequestID { get; set; }
    }

    public class ActionRequest : Action {
        public string Input { get; set; }
        public ActionEnum ActionEnum { get; set; }

        public ActionRequest(Guid requestId, string input, ActionEnum actionEnum) {
            RequestID = requestId;
            Input = input;
            ActionEnum = actionEnum;
        }
    }

    public class ActionResponse : Action {
        public Guid ReponseID { get; set; }
        public string Output { get; set; }

        public ActionResponse(Guid requestId) {
            RequestID = requestId;
            RequestID = Guid.NewGuid();
        }
    }

    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver(MessageLogger messageLogger) {
            Logger = messageLogger;
        }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {

            

            

            return null;
        }


    }
}
