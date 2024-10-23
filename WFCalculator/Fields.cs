namespace WFCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        const string sEmptyStringException = " received an empty string.";
        const string sNonNaturalNumberException = " expected a natural number.";

        static void InputAppend(TextBox target, string value) {
            const string SelfName = "RawInput";
            if (!string.IsNullOrEmpty(value)) {
                target.Text += value;
            }
            else throw new Exception(SelfName + sEmptyStringException);
        }

        static void InputSet(TextBox target, string value) {
            const string SelfName = "InputSet";
            if (!string.IsNullOrEmpty(value)) {
                target.Text = value;
                ParsePoint(ref target);
            }
            else throw new Exception(SelfName + sEmptyStringException);
        }

        static void InputPop(TextBox target, int i) {
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

        static void InputReset(TextBox tbTarget) => tbTarget.Text = string.Empty;
        static string InputGet(TextBox tbTarget) {
            const string SelfName = "InputGet";
            string sTarget = tbTarget.Text;
            if (!string.IsNullOrEmpty(sTarget)) {
                return sTarget;
            }
            else throw new Exception(SelfName + sEmptyStringException);
        }
    }
}