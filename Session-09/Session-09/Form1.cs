namespace Session_09 {
    public partial class Calculator : Form {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        public Calculator() {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "1";

            if (_value1 == null) {
                _value1 = 1;
            }
            else {
                _value2 = 1;
            }

        }

        private void btnTwo_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "2";

            if (_value1 == null) {
                _value1 = 2;
            }
            else {
                _value2 = 2;
            }
        }

        private void btnThree_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "3";

            if (_value1 == null) {
                _value1 = 3;
            }
            else {
                _value2 = 3;
            }
        }

        private void btnFour_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "4";

            if (_value1 == null) {
                _value1 = 4;
            }
            else {
                _value2 = 4;
            }
        }

        private void btnFive_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "5";

            if (_value1 == null) {
                _value1 = 5;
            }
            else {
                _value2 = 5;
            }
        }

        private void btnSix_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "6";

            if (_value1 == null) {
                _value1 = 6;
            }
            else {
                _value2 = 6;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "7";

            if (_value1 == null) {
                _value1 = 7;
            }
            else {
                _value2 = 7;
            }
        }

        private void btnEight_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "8";

            if (_value1 == null) {
                _value1 = 8;
            }
            else {
                _value2 = 8;
            }
        }

        private void btnNine_Click(object sender, EventArgs e) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "9";

            if (_value1 == null) {
                _value1 = 9;
            }
            else {
                _value2 = 9;
            }
        }
    }
    
}