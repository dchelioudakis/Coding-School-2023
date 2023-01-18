using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class PhraseLongestWord {
        //PROPERTIES
        public string Phrase { get; set; }

        //CTOR
        public PhraseLongestWord(string phrase) {
            Phrase = phrase;
        }

        //METHODS
        public string Get() {
            string[] words = Phrase.Split(' ');
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
