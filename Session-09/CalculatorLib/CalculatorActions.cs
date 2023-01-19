using System.ComponentModel;

namespace CalculatorLib {
    public class CalculatorActions {
    
        public CalculatorActions() {

        }

        public decimal? Add(decimal? numberOne, decimal? numberTwo) {
            return numberOne + numberTwo;
        }

        public decimal? Substract(decimal? numberOne, decimal? numberTwo) {
            return numberOne + numberTwo;
        }

        public decimal? Multiply(decimal?numberOne, decimal? numberTwo) {
            return numberOne * numberTwo;
        }

        public decimal? Divide(decimal? numberOne, decimal? numberTwo) {
            return numberOne / numberTwo;
        }

        public decimal? CalcExponential(decimal? numberOne, decimal? numberTwo) {
            return Convert.ToDecimal(Math.Pow((double)numberOne, (double)numberTwo));
        }
    }
}