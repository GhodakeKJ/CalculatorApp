namespace CalculatorApp
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
            groupBox2 = new GroupBox();
            btnclear = new Button();
            btnback = new Button();
            result = new TextBox();
            btndiv = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnmul = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnmin = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnplus = new Button();
            btne = new Button();
            btnp = new Button();
            btn0 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MidnightBlue;
            groupBox2.Controls.Add(btnclear);
            groupBox2.Controls.Add(btnback);
            groupBox2.Controls.Add(result);
            groupBox2.Controls.Add(btndiv);
            groupBox2.Controls.Add(btn9);
            groupBox2.Controls.Add(btn8);
            groupBox2.Controls.Add(btn7);
            groupBox2.Controls.Add(btnmul);
            groupBox2.Controls.Add(btn6);
            groupBox2.Controls.Add(btn5);
            groupBox2.Controls.Add(btn4);
            groupBox2.Controls.Add(btnmin);
            groupBox2.Controls.Add(btn3);
            groupBox2.Controls.Add(btn2);
            groupBox2.Controls.Add(btn1);
            groupBox2.Controls.Add(btnplus);
            groupBox2.Controls.Add(btne);
            groupBox2.Controls.Add(btnp);
            groupBox2.Controls.Add(btn0);
            groupBox2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(141, 74);
            groupBox2.Margin = new Padding(5, 3, 5, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 3, 5, 3);
            groupBox2.Size = new Size(1050, 612);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(568, 147);
            btnclear.Margin = new Padding(5, 3, 5, 3);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(387, 62);
            btnclear.TabIndex = 17;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += button3_Click;
            // 
            // btnback
            // 
            btnback.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(86, 147);
            btnback.Margin = new Padding(5, 3, 5, 3);
            btnback.Name = "btnback";
            btnback.Size = new Size(392, 62);
            btnback.TabIndex = 16;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // result
            // 
            result.Location = new Point(86, 34);
            result.Margin = new Padding(5, 3, 5, 3);
            result.Multiline = true;
            result.Name = "result";
            result.Size = new Size(866, 90);
            result.TabIndex = 18;
            result.TextChanged += result_TextChanged;
            // 
            // btndiv
            // 
            btndiv.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btndiv.Location = new Point(806, 245);
            btndiv.Margin = new Padding(5, 3, 5, 3);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(149, 68);
            btndiv.TabIndex = 15;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += btndiv_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn9.Location = new Point(568, 245);
            btn9.Margin = new Padding(5, 3, 5, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(149, 68);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button18_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn8.Location = new Point(330, 245);
            btn8.Margin = new Padding(5, 3, 5, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(149, 68);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button19_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(86, 245);
            btn7.Margin = new Padding(5, 3, 5, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(149, 68);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button20_Click;
            // 
            // btnmul
            // 
            btnmul.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btnmul.Location = new Point(806, 345);
            btnmul.Margin = new Padding(5, 3, 5, 3);
            btnmul.Name = "btnmul";
            btnmul.Size = new Size(149, 68);
            btnmul.TabIndex = 14;
            btnmul.Text = "*";
            btnmul.UseVisualStyleBackColor = true;
            btnmul.Click += btnmul_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn6.Location = new Point(568, 345);
            btn6.Margin = new Padding(5, 3, 5, 3);
            btn6.Name = "btn6";
            btn6.Size = new Size(149, 68);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button14_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn5.Location = new Point(330, 345);
            btn5.Margin = new Padding(5, 3, 5, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(149, 68);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn4.Location = new Point(86, 345);
            btn4.Margin = new Padding(5, 3, 5, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(149, 68);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button16_Click;
            // 
            // btnmin
            // 
            btnmin.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btnmin.Location = new Point(806, 432);
            btnmin.Margin = new Padding(5, 3, 5, 3);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(149, 68);
            btnmin.TabIndex = 13;
            btnmin.Text = "-";
            btnmin.UseVisualStyleBackColor = true;
            btnmin.Click += btnmin_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn3.Location = new Point(568, 432);
            btn3.Margin = new Padding(5, 3, 5, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(149, 68);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn2.Location = new Point(330, 432);
            btn2.Margin = new Padding(5, 3, 5, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(149, 68);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn1.Location = new Point(86, 432);
            btn1.Margin = new Padding(5, 3, 5, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(149, 68);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btnplus.Location = new Point(806, 517);
            btnplus.Margin = new Padding(5, 3, 5, 3);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(149, 68);
            btnplus.TabIndex = 12;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btne
            // 
            btne.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btne.Location = new Point(568, 517);
            btne.Margin = new Padding(5, 3, 5, 3);
            btne.Name = "btne";
            btne.Size = new Size(149, 68);
            btne.TabIndex = 11;
            btne.Text = "=";
            btne.UseVisualStyleBackColor = true;
            btne.Click += btne_Click;
            // 
            // btnp
            // 
            btnp.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btnp.Location = new Point(330, 517);
            btnp.Margin = new Padding(5, 3, 5, 3);
            btnp.Name = "btnp";
            btnp.Size = new Size(149, 68);
            btnp.TabIndex = 10;
            btnp.Text = ".";
            btnp.UseVisualStyleBackColor = true;
            btnp.Click += btnp_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Wide Latin", 10.8F, FontStyle.Bold);
            btn0.Location = new Point(86, 517);
            btn0.Margin = new Padding(5, 3, 5, 3);
            btn0.Name = "btn0";
            btn0.Size = new Size(149, 68);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1355, 759);
            Controls.Add(groupBox2);
            Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            Text = "CalculatorApp";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnplus;
        private Button btne;
        private Button btnp;
        private Button btn0;
        private Button btndiv;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnmul;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnmin;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private TextBox result;
        private Button btnback;
        private Button btnclear;
    }
}
