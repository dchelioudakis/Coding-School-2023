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

            ActionEnum action = request.Action;
            string inputStr = request.Input;
            Guid requestId = request.RequestID;

            ActionResponse actionResponse = new ActionResponse();
            actionResponse.RequestID = requestId;

            Log("Resolver Start");
            Log(action.ToString());

            try {
                switch (action) {
                    case ActionEnum.Uppercase: {
                        ManipulatorToUppercaseConverter converter = new ManipulatorToUppercaseConverter(inputStr);
                        ManipulatorResponse manipulatorResponse = converter.Manipulate();

                        actionResponse.Output = GetOutput(manipulatorResponse);
                        
                        break;
                    }
                    case ActionEnum.Reverse: {
                        ManipulatorReverser manipulatorReverser = new ManipulatorReverser(inputStr);
                        ManipulatorResponse manipulatorResponse = manipulatorReverser.Manipulate();

                        actionResponse.Output = GetOutput(manipulatorResponse);

                        break;
                    }
                    case ActionEnum.Convert: {
                        ManipulatorDecToBinConverter manipulatorDecToBinConverter = new ManipulatorDecToBinConverter(inputStr);
                        ManipulatorResponse manipulatorResponse = manipulatorDecToBinConverter.Manipulate();

                        actionResponse.Output = GetOutput(manipulatorResponse);

                        break;
                    }

                    default: {
                        actionResponse.Output = "Not Specified Action";

                        break;
                    }
                }
                Log(actionResponse.Output);
            }
            catch (Exception exception) {
                Log(exception.Message);
                throw;
            }
            finally {
                Log("End of Process");
            }

            

            return actionResponse;
        }
        private void Log(string text) {
            Logger.Write(new Message("------------"));

            Message message = new Message(text);
            Logger.Write(message);
        }

        private string GetOutput(ManipulatorResponse manipulatorResponse) {
            string output;

            if (manipulatorResponse.Success) {
                output = manipulatorResponse.OutputStr;
            }
            else {
                output = "Invalid String Input";
            }

            return output;
        }
    }
}
