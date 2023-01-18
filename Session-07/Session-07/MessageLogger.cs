using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class MessageLogger {
        public Message[]? Messages { get; set; }
        private int _MessageCounter = 0;
        //CTOR
        public MessageLogger() {
            Messages = new Message[1000];
        }
        //METHODS
        public void ReadAll() {
            foreach (var message in Messages) {
                if(message != null) {
                    Console.WriteLine(message.Msg);
                }
            }
        }
        public void Clear() {
            Messages = new Message[1000];
            _MessageCounter = 0;
        }
        public void Write(Message message) {
            Messages[_MessageCounter] = message;
            _MessageCounter++;
        }
    }
}
