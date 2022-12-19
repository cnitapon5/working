namespace working
{
    public partial class Form1 : Form
    {
        int num1, num2,num3;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(ans.Text);
            if (op == "+")
            {
                num3=num1 + num2;
                ans.Text = num3.ToString();
            }//+
            if (op == "-")
            {
                num3 = num1 - num2;
                ans.Text = num3.ToString();
            }//-
            if (op == "*")
            {
                num3 = num1 * num2;
                ans.Text = num3.ToString();
            }//*
            if (op == "/")
            {
                num3 = num1 / num2;
                ans.Text = num3.ToString();
            }///

        }
        private void zero_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            ans.Text = ans.Text + "9";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(ans.Text);
            ans.Text = "";
            op = "*";
        }

        private void min_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(ans.Text);
            ans.Text = "";
            op = "-";
        }

        private void divi_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(ans.Text);
            ans.Text = "";
            op = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans.Text = " ";
        }

        private void ans_TextChanged(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(ans.Text);
            ans.Text = "";
            op = "+";
        }
    }
}