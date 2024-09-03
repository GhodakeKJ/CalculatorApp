namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "8";
                i = 1;
            }
            else
            {
                result.Text += "8";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "9";
                i = 1;
            }
            else
            {
                result.Text += "9";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "7";
                i = 1;
            }
            else
            {
                result.Text += "7";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "4";
                i = 1;
            }
            else
            {
                result.Text += "4";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "6";
                i = 1;
            }
            else
            {
                result.Text += "6";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = null;
            val1 = 0.0;
            val2 = 0.0;
            i = 0;
        }
        int i = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "1";
                i = 1;
            }
            else
            {
                result.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "2";
                i = 1;
            }
            else
            {
                result.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "3";
                i = 1;
            }
            else
            {
                result.Text += "3";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "5";
                i = 1;
            }
            else
            {
                result.Text += "5";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "0";
                i = 1;
            }
            else
            {
                result.Text += "0";
            }
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = ".";
                i = 1;
            }
            else if (!result.Text.Contains("."))
            {
                result.Text += ".";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text))
            {
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
        }
        double val1 = 0.0, val2 = 0.0;
        string op = "";
        private void btnplus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text) && result.Text!=".")
            {
                val1 = Convert.ToDouble(result.Text);
                op = "+";
                i = 0;
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text))
            {
                val1 = Convert.ToDouble(result.Text);
                op = "-";
                i = 0;
            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text))
            {
                val1 = Convert.ToDouble(result.Text);
                op = "*";
                i = 0;
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text))
            {
                val1 = Convert.ToDouble(result.Text);
                op = "/";
                i = 0;
            }
        }
        private void result_TextChanged(object sender, EventArgs e)
        {

        }
        double res = 0.0;
        private void btne_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text) && op != "" && result.Text != ".")
            {
                val2 = Convert.ToDouble(result.Text);
                if (op == "+")
                {
                    res = val1 + val2;
                }
                else if (op == "-")
                {
                    res = val1 - val2;
                }
                else if (op == "*")
                {
                    res = val1 * val2;
                }
                else if (op == "/")
                {
                    res = val1 / val2;
                }

                result.Text = res.ToString();
            }
        }
    }
}
