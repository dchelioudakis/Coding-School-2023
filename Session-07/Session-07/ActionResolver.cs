using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver(MessageLogger messageLogger) {
            Logger = messageLogger;
        }

        // METHODS
        public virtual ActionResponse Execute(ActionRequest request) {

            ActionEnum actionEnum = request.ActionEnum;
            string inputStr = request.Input;
            Guid requestId = request.RequestID;

            ActionResponse actionResponse = new ActionResponse();
            actionResponse.RequestID = requestId;

            switch (actionEnum) {
                case ActionEnum.Uppercase: {

                        break;
                    }
                case ActionEnum.Reverse: {


                        break;
                    }

                default: {



                        break;
                    }
            }

            return actionResponse;
        }
    }
}
