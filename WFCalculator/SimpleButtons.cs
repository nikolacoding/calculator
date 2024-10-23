namespace WFCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private void button_1_Click(object sender, EventArgs e) => InputAppend(textBox_main, "1");
        private void button_2_Click(object sender, EventArgs e) => InputAppend(textBox_main, "2");
        private void button_3_Click(object sender, EventArgs e) => InputAppend(textBox_main, "3");
        private void button_4_Click(object sender, EventArgs e) => InputAppend(textBox_main, "4");
        private void button_5_Click(object sender, EventArgs e) => InputAppend(textBox_main, "5");
        private void button_6_Click(object sender, EventArgs e) => InputAppend(textBox_main, "6");
        private void button_7_Click(object sender, EventArgs e) => InputAppend(textBox_main, "7");
        private void button_8_Click(object sender, EventArgs e) => InputAppend(textBox_main, "8");
        private void button_9_Click(object sender, EventArgs e) => InputAppend(textBox_main, "9");
        private void button_0_Click(object sender, EventArgs e) => InputAppend(textBox_main, "0");
        private void button_point_Click(object sender, EventArgs e) => InputAppend(textBox_main, ".");
        private void button_backspace_Click(object sender, EventArgs e) => InputPop(textBox_main, 1);
        private void button_divide_Click(object sender, EventArgs e) => InputAppend(textBox_main, "/");
        private void button_multiply_Click(object sender, EventArgs e) => InputAppend(textBox_main, "*");
        private void button_minus_Click(object sender, EventArgs e) => InputAppend(textBox_main, "-");
        private void button_plus_Click(object sender, EventArgs e) => InputAppend(textBox_main, "+");
    }
}
