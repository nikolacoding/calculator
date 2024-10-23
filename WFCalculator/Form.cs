using System.Data;
using System.Diagnostics;

namespace WFCalculator
{
    public partial class Form : System.Windows.Forms.Form {
        public Form() {
            InitializeComponent();
        }

        // on awake
        private void Form_Load(object sender, EventArgs e) {
            InputReset(textBox_main);
            InputReset(textBox_res);
        }
    }
}
