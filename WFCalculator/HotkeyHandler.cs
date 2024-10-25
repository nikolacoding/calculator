using System.Diagnostics;

namespace WFCalculator {
    public partial class Form : System.Windows.Forms.Form {

        static bool GetSingleKey(KeyEventArgs e, Keys key) => e.KeyCode == key;

        static bool GetDoubleKey(KeyEventArgs e, Keys key1, Keys key2) => e.KeyData == (key1 | key2);

        private void Form_KeyDown(object sender, KeyEventArgs e) {
            #region Quick input manipulation
            // <- (backspace)
            if (GetSingleKey(e, Keys.Back)) InputPop(textBox_main, 1);
            // CTRL <- (ctrl + backspace)   OR   delete (del)
            if (GetDoubleKey(e, Keys.Control, Keys.Back) ||
                GetSingleKey(e, Keys.Delete) ||
                GetSingleKey(e, Keys.C))
                    InputReset(textBox_main);
            #endregion

            #region Numbers
            if (GetSingleKey(e, Keys.D1)) InputAppend(textBox_main, "1");
            if (GetSingleKey(e, Keys.D2)) InputAppend(textBox_main, "2");
            if (GetSingleKey(e, Keys.D3)) InputAppend(textBox_main, "3");
            if (GetSingleKey(e, Keys.D4)) InputAppend(textBox_main, "4");
            if (GetSingleKey(e, Keys.D5)) InputAppend(textBox_main, "5");
            if (GetSingleKey(e, Keys.D6)) InputAppend(textBox_main, "6");
            if (GetSingleKey(e, Keys.D7)) InputAppend(textBox_main, "7");
            if (GetSingleKey(e, Keys.D8) && !e.Shift) InputAppend(textBox_main, "8");
            if (GetSingleKey(e, Keys.D9)) InputAppend(textBox_main, "9");

            if (GetSingleKey(e, Keys.D0) && !string.IsNullOrEmpty(textBox_main.Text)) 
                InputAppend(textBox_main, "0");
            #endregion

            #region Operators
            // moving the evaluation textbox to the input textbox
            if (GetSingleKey(e, Keys.A)) { InputSwap(textBox_main, textBox_res); InputReset(textBox_res); }

            // evaluation
            if (GetSingleKey(e, Keys.D)) EvalExpression(textBox_main, textBox_res);

            // direct input
            if (GetSingleKey(e, Keys.OemPeriod)) AddComma(textBox_main);

            if (GetDoubleKey(e, Keys.Shift, Keys.D8)) AddOperator(textBox_main, "*");
            if (GetSingleKey(e, Keys.OemQuestion)) AddOperator(textBox_main, "/");
            if (GetSingleKey(e, Keys.OemMinus)) AddOperator(textBox_main, "-");
            if (GetSingleKey(e, Keys.Oemplus)) AddOperator(textBox_main, "+");

            #endregion Operators
        }
    }
}
