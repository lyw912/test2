namespace _3._3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object type = comboBox1.SelectedItem;
            int a = Int32.Parse(textBox1.Text);
            double b = Int32.Parse(textBox2.Text);
            if (type.ToString() == "+")
            {
                textBox3.Text = (a + b).ToString();
            }
            if (type.ToString() == "-")
            {
                textBox3.Text = (a - b).ToString();
            }
            if (type.ToString() == "*")
            {
                textBox3.Text = (a * b).ToString();
            }
            if (type.ToString() == "/")
            {
                if (textBox2.Text == "0")
                {
                    MessageBox.Show(" ‰»Î¥ÌŒÛ");
                }
                textBox3.Text = (a / b).ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            comboBox1.Text = " ";
        }
    }
}