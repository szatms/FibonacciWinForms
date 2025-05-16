namespace FibonacciWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int number)) {
                MessageBox.Show("Error: not a number!! | Invalid input.");
                textBox1.Clear();
                textBox1.Focus();
            }
            
            if (number < 0) {
                textBox2.Text = $"-1";
                return;
            }
            if (number == 0) {
                textBox2.Text = $"0";
                return;
            }
            if (number == 1) {
                textBox2.Text = $"1";
                return;
            }

            int first = 0;
            int second = 1;
            int next = 0;

            for (int i = 2; i < number; i++) {
                next = first + second;
                first = second;
                second = next;
            }

            textBox2.Text = $"{second}";
        }
    }
}
