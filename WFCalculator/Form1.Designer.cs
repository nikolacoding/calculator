namespace WFCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button_7 = new Button();
            button_8 = new Button();
            button_9 = new Button();
            button_6 = new Button();
            button_5 = new Button();
            button_4 = new Button();
            button_3 = new Button();
            button_2 = new Button();
            button_1 = new Button();
            textBox_main = new TextBox();
            textBox_res = new TextBox();
            button_equals = new Button();
            button_point = new Button();
            button_0 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button_sin = new Button();
            button_cos = new Button();
            button_tan = new Button();
            checkBox_qm = new CheckBox();
            button_backspace = new Button();
            SuspendLayout();
            // 
            // button_7
            // 
            button_7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_7.Location = new Point(12, 73);
            button_7.Name = "button_7";
            button_7.Size = new Size(37, 34);
            button_7.TabIndex = 1;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_7_Click;
            // 
            // button_8
            // 
            button_8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_8.Location = new Point(55, 73);
            button_8.Name = "button_8";
            button_8.Size = new Size(37, 34);
            button_8.TabIndex = 2;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_8_Click;
            // 
            // button_9
            // 
            button_9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_9.Location = new Point(98, 73);
            button_9.Name = "button_9";
            button_9.Size = new Size(37, 34);
            button_9.TabIndex = 3;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_9_Click;
            // 
            // button_6
            // 
            button_6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_6.Location = new Point(98, 113);
            button_6.Name = "button_6";
            button_6.Size = new Size(37, 34);
            button_6.TabIndex = 6;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_6_Click;
            // 
            // button_5
            // 
            button_5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_5.Location = new Point(55, 113);
            button_5.Name = "button_5";
            button_5.Size = new Size(37, 34);
            button_5.TabIndex = 5;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_5_Click;
            // 
            // button_4
            // 
            button_4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_4.Location = new Point(12, 113);
            button_4.Name = "button_4";
            button_4.Size = new Size(37, 34);
            button_4.TabIndex = 4;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_4_Click;
            // 
            // button_3
            // 
            button_3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_3.Location = new Point(98, 153);
            button_3.Name = "button_3";
            button_3.Size = new Size(37, 34);
            button_3.TabIndex = 9;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_3_Click;
            // 
            // button_2
            // 
            button_2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_2.Location = new Point(55, 153);
            button_2.Name = "button_2";
            button_2.Size = new Size(37, 34);
            button_2.TabIndex = 8;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_2_Click;
            // 
            // button_1
            // 
            button_1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_1.Location = new Point(12, 153);
            button_1.Name = "button_1";
            button_1.Size = new Size(37, 34);
            button_1.TabIndex = 7;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // textBox_main
            // 
            textBox_main.BorderStyle = BorderStyle.FixedSingle;
            textBox_main.Font = new Font("Segoe UI", 20F);
            textBox_main.Location = new Point(12, 12);
            textBox_main.Name = "textBox_main";
            textBox_main.Size = new Size(123, 43);
            textBox_main.TabIndex = 10;
            textBox_main.Text = "6*10*3";
            textBox_main.TextChanged += textBox_main_TextChanged;
            // 
            // textBox_res
            // 
            textBox_res.BorderStyle = BorderStyle.FixedSingle;
            textBox_res.Font = new Font("Segoe UI", 20F);
            textBox_res.Location = new Point(166, 12);
            textBox_res.Name = "textBox_res";
            textBox_res.Size = new Size(80, 43);
            textBox_res.TabIndex = 11;
            textBox_res.Text = "180";
            textBox_res.TextChanged += textBox_res_TextChanged;
            // 
            // button_equals
            // 
            button_equals.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_equals.Location = new Point(98, 193);
            button_equals.Name = "button_equals";
            button_equals.Size = new Size(37, 34);
            button_equals.TabIndex = 14;
            button_equals.Text = "=";
            button_equals.UseVisualStyleBackColor = true;
            button_equals.Click += button_equals_Click;
            // 
            // button_point
            // 
            button_point.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_point.Location = new Point(55, 193);
            button_point.Name = "button_point";
            button_point.Size = new Size(37, 34);
            button_point.TabIndex = 13;
            button_point.Text = ".";
            button_point.UseVisualStyleBackColor = true;
            button_point.Click += button_point_Click;
            // 
            // button_0
            // 
            button_0.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_0.Location = new Point(12, 193);
            button_0.Name = "button_0";
            button_0.Size = new Size(37, 34);
            button_0.TabIndex = 12;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_0_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button_sin
            // 
            button_sin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_sin.Location = new Point(141, 73);
            button_sin.Name = "button_sin";
            button_sin.Size = new Size(58, 34);
            button_sin.TabIndex = 16;
            button_sin.Text = "sin";
            button_sin.UseVisualStyleBackColor = true;
            // 
            // button_cos
            // 
            button_cos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_cos.Location = new Point(141, 113);
            button_cos.Name = "button_cos";
            button_cos.Size = new Size(58, 34);
            button_cos.TabIndex = 17;
            button_cos.Text = "cos";
            button_cos.UseVisualStyleBackColor = true;
            // 
            // button_tan
            // 
            button_tan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_tan.Location = new Point(141, 153);
            button_tan.Name = "button_tan";
            button_tan.Size = new Size(58, 34);
            button_tan.TabIndex = 18;
            button_tan.Text = "tan";
            button_tan.UseVisualStyleBackColor = true;
            // 
            // checkBox_qm
            // 
            checkBox_qm.AutoSize = true;
            checkBox_qm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_qm.Location = new Point(12, 233);
            checkBox_qm.Name = "checkBox_qm";
            checkBox_qm.Size = new Size(91, 19);
            checkBox_qm.TabIndex = 19;
            checkBox_qm.Text = "Quick Mode";
            checkBox_qm.UseVisualStyleBackColor = true;
            checkBox_qm.CheckedChanged += checkBox_qm_CheckedChanged;
            // 
            // button_backspace
            // 
            button_backspace.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_backspace.Location = new Point(141, 193);
            button_backspace.Name = "button_backspace";
            button_backspace.Size = new Size(58, 34);
            button_backspace.TabIndex = 20;
            button_backspace.Text = "<--";
            button_backspace.UseVisualStyleBackColor = true;
            button_backspace.Click += button_backspace_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(257, 253);
            Controls.Add(button_backspace);
            Controls.Add(checkBox_qm);
            Controls.Add(button_tan);
            Controls.Add(button_cos);
            Controls.Add(button_sin);
            Controls.Add(button_equals);
            Controls.Add(button_point);
            Controls.Add(button_0);
            Controls.Add(textBox_res);
            Controls.Add(textBox_main);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_7;
        private Button button_8;
        private Button button_9;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_3;
        private Button button_2;
        private Button button_1;
        private TextBox textBox_main;
        private TextBox textBox_res;
        private Button button_equals;
        private Button button_point;
        private Button button_0;
        private ContextMenuStrip contextMenuStrip1;
        private Button button_sin;
        private Button button_cos;
        private Button button_tan;
        private CheckBox checkBox_qm;
        private Button button_backspace;
    }
}
