using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {
    public class ManipulatorToUppercaseConverter : StringManipulator{
        //CTOR
        public ManipulatorToUppercaseConverter(string inputStr) {
            InputStr = inputStr;
        }
        //METHODS
        public override ManipulatorResponse Manipulate() {

            bool success = false;
            string outputStr = string.Empty;

            if (Regex.IsMatch(InputStr, "^[a-zA-Z ]+$")) {
                string longestWord = GetLongestWord(InputStr);

                success = true;
                outputStr = longestWord.ToUpper();
            }
            
            return new ManipulatorResponse(success, outputStr);
        }

        public string GetLongestWord(string phrase) {
            string[] words = phrase.Split(' ');
            int maxLength = 0;
            string longestWord = string.Empty;

            for (int i = 0; i < words.Length; i++) {
                if (words[i].Length > maxLength) {
                    longestWord = words[i];
                    maxLength = words[i].Length;
                }
            }

            return longestWord;
        }
    }
}
