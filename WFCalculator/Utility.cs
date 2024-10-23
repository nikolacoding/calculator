namespace WFCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        // parses the point/comma symbol ('.' / ',') strictly to the '.' form since the built-in conversion
        // methods mix them up all the time and some break unless '.' is used
        public static void ParsePoint(ref TextBox tb) {
            tb.Text = tb.Text.Replace(',', '.');
        }
    }
}
