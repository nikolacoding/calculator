using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;

namespace WFCalculator
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        // on load (valjda)
        private void Form1_Load(object sender, EventArgs e) {
            textBox_main.Text = "";
        }

        private void button_1_Click(object sender, EventArgs e) => RawInput(textBox_main, "1");
        private void button_2_Click(object sender, EventArgs e) => RawInput(textBox_main, "2");
        private void button_3_Click(object sender, EventArgs e) => RawInput(textBox_main, "3");
        private void button_4_Click(object sender, EventArgs e) => RawInput(textBox_main, "4");
        private void button_5_Click(object sender, EventArgs e) => RawInput(textBox_main, "5");
        private void button_6_Click(object sender, EventArgs e) => RawInput(textBox_main, "6");
        private void button_7_Click(object sender, EventArgs e) => RawInput(textBox_main, "7");
        private void button_8_Click(object sender, EventArgs e) => RawInput(textBox_main, "8");
        private void button_9_Click(object sender, EventArgs e) => RawInput(textBox_main, "9");
        private void button_0_Click(object sender, EventArgs e) => RawInput(textBox_main, "0");
        private void button_point_Click(object sender, EventArgs e) => RawInput(textBox_main, ".");
        private void button_backspace_Click(object sender, EventArgs e) => InputPop(textBox_main, 1);

        // '='
        private void button_equals_Click(object sender, EventArgs e) {

        }

        // main/input display
        private void textBox_main_TextChanged(object sender, EventArgs e) {

        }

        // result
        private void textBox_res_TextChanged(object sender, EventArgs e) {

        }

        // quick mode checkbox
        private void checkBox_qm_CheckedChanged(object sender, EventArgs e) {

        }

        const string sEmptyStringException = " received an empty string.";
        const string sNonNaturalNumberException = " expected a natural number.";
        private void RawInput(TextBox target, string value) {
            const string SelfName = "RawInput";
            if (!string.IsNullOrEmpty(value)) {
                target.Text += value;
            }
            else throw new Exception(SelfName + sEmptyStringException);
        }

        private void InputPop(TextBox target, int i) {
            const string SelfName = "InputPop";
            // caller error, throw exception
            if (i >= 1) {
                // user "error", no need for an exception
                if (!string.IsNullOrEmpty(target.Text)) { 
                    target.Text = target.Text.Remove(target.Text.Length - i);
                }
            }
            else throw new Exception(SelfName + sNonNaturalNumberException);
        }

        private void InputReset(TextBox target) {

        }
    }
}
