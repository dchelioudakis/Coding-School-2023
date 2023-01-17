using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
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
}
