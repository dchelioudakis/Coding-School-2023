using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class Message {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        //Cannot be named Message because is the same with class name
        public string Msg { get; set; }

        public Message(string msg) {
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            Msg = msg;
        }
    }
}
