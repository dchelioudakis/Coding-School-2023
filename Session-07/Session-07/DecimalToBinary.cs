using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class DecimalToBinary : ActionResolver {

        // CTOR
        public DecimalToBinary(MessageLogger messageLogger) :base(messageLogger) {
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
            decimal decimalNum;

            if (Decimal.TryParse(inputStr, out decimalNum)) {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; decimalNum > 0; i++) {
                    sb.Clear();
                    sb.Insert(0, decimalNum % 2);
                }
                actionResponse.Output = sb.ToString();
            }
            else {
                actionResponse.Output = "Not a decimal number";
            }

            sbForLog.AppendLine(actionResponse.Output);

            Message msgToLog = new Message();
            msgToLog.Msg = sbForLog.ToString();


            this.Logger.Write(msgToLog);


            return actionResponse;
        }
    }
}
