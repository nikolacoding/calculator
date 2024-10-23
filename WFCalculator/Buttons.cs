using System.Data;
using System.Diagnostics;

namespace WFCalculator
{
    public partial class Form : System.Windows.Forms.Form {

        // '='
        private void button_equals_Click(object sender, EventArgs e) {
            TextBox tbMain = textBox_main;
            TextBox tbRes = textBox_res;
            if (!string.IsNullOrEmpty(tbMain.Text)) {
                DataTable dt = new();

                string sExpression = InputGet(textBox_main); // takes the string form of the exception directly from the TB
                var oComputedExpression = dt.Compute(sExpression, ""); // computes it into an object
                double fComputedExpression = Convert.ToDouble(oComputedExpression); // converts it to a double
                string sComputedExpresssion = Convert.ToString(fComputedExpression); // converts it to a string
                InputSet(tbRes, sComputedExpresssion);
            }
        }
        // <--
        private void button_flip_Click(object sender, EventArgs e) => textBox_main.Text = textBox_res.Text;

        // main/input display
        private void textBox_main_TextChanged(object sender, EventArgs e) {

        }

        // result
        private void textBox_res_TextChanged(object sender, EventArgs e) {

        }

        // quick mode checkbox
        private void checkBox_qm_CheckedChanged(object sender, EventArgs e) {
            Debug.WriteLine("d");
        }
    }
}