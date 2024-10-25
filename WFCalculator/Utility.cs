using System.Data;
using System.Drawing.Text;
using System.Runtime.ExceptionServices;

namespace WFCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        // parses the point/comma symbol ('.' / ',') strictly to the '.' form since the built-in conversion
        // methods mix them up all the time and some break unless '.' is used
        private static void ParsePoint(ref TextBox tb) {
            tb.Text = tb.Text.Replace(',', '.');
        }

        private static void AddComma(TextBox tb) {
            if (!tb.Text.EndsWith(".")) {
                InputAppend(tb, ".");
            }
        }

        private static List<string> validOperators = ["*", "/", "-", "+"];
        private const string sInvalidOperatorException = "AddOperator called with an improper operator.";
        private static void AddOperator(TextBox tb, string oper) {
            if (validOperators.Contains(oper)) {
                foreach (string op in validOperators) {
                    // if the input string already ends with an operator, exit function
                    if (tb.Text.EndsWith(op)) return;
                }
            }
            else throw new Exception(sInvalidOperatorException);

            // otherwise append the operator to the input string
            InputAppend(tb, oper);
        }

        // pre-evaluation setup:
        //      a) if it ends with a comma/point, append a zero
        //      b) if it ends with an operator, remove it
        // p.s: the string is already protected from ending with more than one operator and with more than one comma
        private static void PreEval(TextBox tb) {
            // a)
            if (tb.Text.EndsWith(".")) {
                InputAppend(tb, "0");
                return;
            }

            // b)
            foreach (string op in validOperators) {
                if (tb.Text.EndsWith(op)) {
                    InputPop(tb, 1);
                    return;
                }
            }
        }

        private static void EvalExpression(TextBox tbFrom, TextBox tbTo) {
            if (!string.IsNullOrEmpty(tbFrom.Text)) {
                PreEval(tbFrom);
                DataTable dt = new();

                string sExpression = InputGet(tbFrom); // takes the string form of the exception directly from the TB
                var oComputedExpression = dt.Compute(sExpression, ""); // computes it into an object
                double fComputedExpression = Convert.ToDouble(oComputedExpression); // converts it to a double
                string sComputedExpresssion = Convert.ToString(fComputedExpression); // converts it to a string
                InputSet(tbTo, sComputedExpresssion);
                 
            }
        }
    }
}
