using System.Data;

namespace LAB8
{
    public partial class Form1 : Form
    {
        MyComplex isEquals = new MyComplex();
        MyComplex c1 = new MyComplex();
        MyComplex c2 = new MyComplex();
        private void InterData()
        {
            c1['r'] = double.Parse(textBoxValue1.Text);
            c1['i'] = double.Parse(textBoxImag1.Text);
            c2['r'] = double.Parse(textBoxValue2.Text);
            c2['i'] = double.Parse(textBoxImag2.Text);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                InterData();
                isEquals = c1 * c2;
                if (isEquals['i'] >= 0)
                    textBoxAnswer.Text = $"{isEquals['r']} + {isEquals['i']}i";
                else
                    textBoxAnswer.Text = $"{isEquals['r']} - {isEquals['i']}i";

            }
            catch
            {
                MessageBox.Show("Erorr!");
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                InterData();
                isEquals = c1 + c2;
                if (isEquals['i'] >= 0)
                    textBoxAnswer.Text = $"{isEquals['r']} + {isEquals['i']}i";
                else
                    textBoxAnswer.Text = $"{isEquals['r']} - {isEquals['i']}i";
            }
            catch
            {
                MessageBox.Show("Erorr!");
            }

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                InterData();
                isEquals = c1 / c2;
                if (isEquals['i'] >= 0)
                    textBoxAnswer.Text = $"{isEquals['r']} + {isEquals['i']}i";
                else
                    textBoxAnswer.Text = $"{isEquals['r']} - {isEquals['i']}i";

            }
            catch
            {
                MessageBox.Show("Erorr!");
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                InterData();
                isEquals = c1 - c2;
                if (isEquals['i'] >= 0)
                    textBoxAnswer.Text = $"{isEquals['r']} + {isEquals['i']}i";
                else
                    textBoxAnswer.Text = $"{isEquals['r']} - {isEquals['i']}i";
            }
            catch
            {
                MessageBox.Show("Erorr!");
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            InterData();
            if (c1.r.Equals(c2.r) && c1.i.Equals(c2.i))
            {
                textBoxAnswer.Text = "True";
            }
            else
            {
                textBoxAnswer.Text = "False";
            }
        }

        private void buttonNoEquals_Click(object sender, EventArgs e)
        {
            try
            {
                InterData();
                if (c1.r.Equals(c2.r) && c1.i.Equals(c2.i))
                {
                    textBoxAnswer.Text = "Fasle";
                }
                else
                {
                    textBoxAnswer.Text = "True";
                }
            }
            catch
            {
                MessageBox.Show("Erorr!");
            }
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            try
            {
                InterData();
                int hash1 = c1.GetHashCode();
                int hash2 = c2.GetHashCode();
                if (c1.r >= c2.r && c1.i >= c2.i)
                {
                    textBoxAnswer.Text = "True";
                }
                else
                {
                    textBoxAnswer.Text = "False";
                }
            }
            catch
            {
                MessageBox.Show("Erorr!");
            }
        }

        private void buttonLess_Click(object sender, EventArgs e)
        {
            try
            {
                InterData();
                if (c1.r <= c2.r && c1.i <= c2.i)
                {
                    textBoxAnswer.Text = "True";
                }
                else
                {
                    textBoxAnswer.Text = "False";
                }
            }
            catch
            {
                MessageBox.Show("Erorr!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = "";
            textBoxImag1.Text = "";
            textBoxImag2.Text = "";
            textBoxValue1.Text = "";
            textBoxValue2.Text = "";
        }

        private void textBoxValues_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}