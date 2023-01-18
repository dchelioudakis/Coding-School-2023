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

            Logger.Write(new Message("Resolver Start"));
            Logger.Write(new Message(actionEnum.ToString()));

            try {
                switch (actionEnum) {
                    case ActionEnum.Uppercase: {
                        ManipulatorToUppercaseConverter converter = new ManipulatorToUppercaseConverter(inputStr);
                        ManipulatorResponse manipulatorResponse = converter.Manipulate();

                        if (manipulatorResponse.Success) {
                            actionResponse.Output = manipulatorResponse.OutputStr;
                        }
                        else {
                            actionResponse.Output = "Invalid String Input";
                        }
                        break;
                    }
                    case ActionEnum.Reverse: {
                        ManipulatorReverser manipulatorReverser = new ManipulatorReverser(inputStr);
                        ManipulatorResponse manipulatorResponse = manipulatorReverser.Manipulate();

                        if (manipulatorResponse.Success) {
                            actionResponse.Output = manipulatorResponse.OutputStr;
                        }
                        else {
                            actionResponse.Output = "Invalid String Input";
                        }

                        break;
                    }
                    case ActionEnum.Convert: {
                        ManipulatorDecToBinConverter manipulatorDecToBinConverter = new ManipulatorDecToBinConverter(inputStr);
                        ManipulatorResponse manipulatorResponse = manipulatorDecToBinConverter.Manipulate();

                        if (manipulatorResponse.Success) {
                            actionResponse.Output = manipulatorResponse.OutputStr;
                        }
                        else {
                            actionResponse.Output = "Invalid String Input";
                        }

                        break;
                    }

                    default: {
                        actionResponse.Output = "Not Specified Action";

                        break;
                    }
                }
                Logger.Write(new Message(actionResponse.Output));
            }
            catch (Exception exception) {
                Logger.Write(new Message(exception.Message));
                throw;
            }
            finally {

            }

            

            return actionResponse;
        }
    }
}
