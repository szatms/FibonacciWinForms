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

            int first = 1;
            int second = 0;
            int third = 0;

            for (int i = 0; i < number; i++) {
                third = first + second;
                first = second;
                second = third;
            }

            textBox2.Text = $"{third}";
        }
    }
}
