using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringToReversed : ActionResolver {

        public StringToReversed(MessageLogger messageLogger) : base(messageLogger) {
            Logger = messageLogger;
        }
        public override ActionResponse Execute(ActionRequest request) {
            ActionEnum actionEnum = request.ActionEnum;
            string inputStr = request.Input;
            Guid requestId = request.RequestID;

            ActionResponse actionResponse = new ActionResponse();
            actionResponse.RequestID = requestId;

            StringBuilder sbForLog = new StringBuilder();
            sbForLog.AppendLine(actionEnum.ToString());

            if (Regex.IsMatch(inputStr, "^[a-zA-Z]+$")) {

                StringReverse myReverse = new StringReverse();
                myReverse.Str = inputStr;

                string reversedOutput = myReverse.Reverse();

                actionResponse.Output = reversedOutput;
            }
            else {
                actionResponse.Output = "Not valid string";
            }

            sbForLog.AppendLine(actionResponse.Output);

            Message msgToLog = new Message();
            msgToLog.Msg = sbForLog.ToString();


            this.Logger.Write(msgToLog);


            return actionResponse;
        }
    }
}
