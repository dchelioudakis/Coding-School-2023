using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09 {
    public class MathExpression {
        public string Expression { get; set; }
        public MathExpression(string expression) {
            Expression = expression;
        }
        public string[] Analyze() {
            string[] expressionAnalysis = new string[3];
            char[]? delimiters = ("-+x÷^").ToCharArray();
            expressionAnalysis = Expression.Split(delimiters);

            return expressionAnalysis ;
        }
    }
}
