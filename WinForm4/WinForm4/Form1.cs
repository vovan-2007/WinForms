namespace WinForm4
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = button2;
        }
        private int count = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = ("Счётчик: " + count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                count = int.Parse(textBox1.Text);
                label1.Text = ("Значение " + count.ToString() + " записано");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ничего не ввели!",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
