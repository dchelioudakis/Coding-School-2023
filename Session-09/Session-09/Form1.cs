using CalculatorLib;
using System.Linq.Expressions;
using System.Security.AccessControl;

namespace Session_09 {
    public partial class Calculator : Form {
        private decimal? _valueA = null;
        private decimal? _valueB = null;
        private decimal? _result = null;
        private CalcOperation _calcOperation;
        enum CalcOperation {
            Addition,
            Substraction,
            Multiplication,
            Division,
            Exponential,
            Root,
        }

        public Calculator() {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(0);
        }

        private void btnOne_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(1);
        }

        private void btnTwo_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(2);
        }

        private void btnThree_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(3);
        }

        private void btnFour_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(4);
        }

        private void btnFive_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(5);
        }

        private void btnSix_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(6);
        }

        private void btnSeven_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(7);
        }

        private void btnEight_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(8);
        }

        private void btnNine_Click(object sender, EventArgs e) {
            InitializeNumericalBtn(9);
        }



        private void btnResult_Click(object sender, EventArgs e) {
            MathExpression expression = new MathExpression(ctrlDisplay.Text);
            string[] expressionArray = expression.Analyze();


            
            _valueA = Convert.ToDecimal(expressionArray[0]);
            _valueB = Convert.ToDecimal(expressionArray[1]);
           
            
            //calcOperationFromDelimiter(string delimiter)

            ctrlDisplay.Text += " = ";
            CalculatorActions calc = new CalculatorActions();
            try {
                switch (_calcOperation) {
                    case CalcOperation.Addition:

                        _result = calc.Add(_valueA, _valueB);
                        break;
                    case CalcOperation.Substraction:

                        _result = calc.Substract(_valueA, _valueB);
                        break;

                    case CalcOperation.Multiplication:

                        _result = calc.Multiply(_valueA, _valueB);
                        break;

                    case CalcOperation.Division:
                        if (_valueB != 0) {
                            _result = calc.Divide(_valueA, _valueB);
                        }
                        else {
                            ClearCalculator();
                            ctrlDisplay.Text = "Cannot Divide By Zero";
                        }

                        break;

                    case CalcOperation.Exponential:
                        _result = calc.CalcExponential(_valueA, _valueB);
                        break;

                    case CalcOperation.Root:
                        
                        break;
                }

                ctrlDisplay.Text += _result;
            }
            catch (Exception) {
                ClearCalculator();
                ctrlDisplay.Text = "Error";
                throw;
            }
            
        }

        private void btnAddition_Click(object sender, EventArgs e) {
            InitializeCalculationBtn();
            ctrlDisplay.Text += "+";
            _calcOperation = CalcOperation.Addition;
        }

        private void btnSubstraction_Click(object sender, EventArgs e) {
            InitializeCalculationBtn();
            ctrlDisplay.Text += "-";
            _calcOperation = CalcOperation.Substraction;
        }

        private void btnMultiplication_Click(object sender, EventArgs e) {
            InitializeCalculationBtn();
            ctrlDisplay.Text += "x";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void btnDivision_Click(object sender, EventArgs e) {
            InitializeCalculationBtn();
            ctrlDisplay.Text += "÷";
            _calcOperation = CalcOperation.Division;
        }

        private void btnExponential_Click(object sender, EventArgs e) {
            InitializeCalculationBtn();
            ctrlDisplay.Text += "^";
            _calcOperation = CalcOperation.Exponential;
        }

        private void btnRoot_Click(object sender, EventArgs e) {
            InitializeCalculationBtn();
            _valueA = Convert.ToDecimal(ctrlDisplay.Text);

            _result = Convert.ToDecimal(Math.Sqrt((double)_valueA));
            ctrlDisplay.Text = "√" + _valueA + " = " + _result;
            _calcOperation = CalcOperation.Root;
        }

        private void InitializeNumericalBtn(int value) {
            if (_result == null) {

                ctrlDisplay.Text += value.ToString();
            }
            else {
                ctrlDisplay.Text += string.Empty;
            }

            if (_valueA == null) {
                _valueA = value;
            }
            else {
                _valueB = value;
            }

        }

        private void InitializeCalculationBtn() {
            if (_result != null) {
                _valueA = _result;
                _result = null;
                _valueB = null;
                ctrlDisplay.Text = _valueA.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ClearCalculator();
        }

        private void ClearCalculator() {
            ctrlDisplay.Text = string.Empty;
            _valueA = null;
            _valueB = null;
            _result = null;
        }

        private void calcOperationFromDelimiter(string delimiter) {
            switch (delimiter) {
                case "+": {
                    _calcOperation = CalcOperation.Addition;
                    break;
                }
                case "-": {
                    _calcOperation = CalcOperation.Substraction;
                    break;
                }
                case "*": {
                    _calcOperation = CalcOperation.Multiplication;
                    break;
                }
                case "/": {
                    _calcOperation = CalcOperation.Multiplication;
                    break;
                }
                //case "/": {
                //    _calcOperation = CalcOperation.Multiplication;
                //    break;
                //}
                default:
                    break;
            }
        }

        private void btnDelimiter_Click(object sender, EventArgs e) {
            ctrlDisplay.Text += ".";
        }
    }
    
}