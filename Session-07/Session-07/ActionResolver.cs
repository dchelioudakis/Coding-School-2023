using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {

    public enum ActionEnum {
        Convert,
        Uppercase,
        Reverse
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

            ActionEnum actionEnum = request.ActionEnum;
            string inputStr = request.Input;
            Guid requestId = request.RequestID;

            ActionResponse actionResponse = new ActionResponse();
            actionResponse.RequestID = requestId;


            switch (actionEnum) {
                case ActionEnum.Convert: {
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
                    break;
                }
                case ActionEnum.Uppercase: {
                    if (Regex.IsMatch(inputStr, "^[a-zA-Z ]+$")) {
                        string[] words = inputStr.Split(' ');
                        int maxLength = 0;
                        string longestWord = "";

                        for (int i = 0; i < words.Length; i++) {
                            if (words[i].Length > maxLength) {
                                longestWord = words[i];
                                maxLength = words[i].Length;
                            }
                        }
                        actionResponse.Output = longestWord.ToUpper();
                    }
                    else {
                        actionResponse.Output = "Not valid string";
                    }
                    break;
                }
                case ActionEnum.Reverse: {
                    if (Regex.IsMatch(inputStr, "^[a-zA-Z]+$")) {

                        StringReverse myReverse = new StringReverse();
                        myReverse.Str = inputStr;

                        string reversedOutput = myReverse.Reverse();

                        actionResponse.Output = reversedOutput;
                    }
                    else {
                        actionResponse.Output = "Not valid string";
                    }

                    break;
                }

                default: {

                        actionResponse.Output = "Not Specified Action";

                        break;
                }
            }



            return actionResponse;
        }


    }
}
