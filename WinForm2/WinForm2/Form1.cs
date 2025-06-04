namespace WinForm2
{
    public partial class Form1 : Form
    {
        public string userInput = ("Введите текст");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = ("Привет, " + textBox1.Text + "!");
            label1.Text = userInput;
        }
    }
}
