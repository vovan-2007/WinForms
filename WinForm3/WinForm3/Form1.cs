namespace WinForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = button1;
        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {
            textBoxT.ForeColor = Color.Black;
        }

        private void buttonCTF_Click(object sender, EventArgs e)
        {
            try
            {
                double c = double.Parse(textBoxT.Text);
                double f = (c * 9 / 5) + 32;
                labelResult.Text = "Результат: " + f.ToString("F2") + " °F";
            }
            catch (FormatException)
            {
                labelResult.Text = "Неверный ввод!";
            }
        }

        private void buttonFTC_Click(object sender, EventArgs e)
        {
            try
            {
                double f = double.Parse(textBoxT.Text);
                double c = (f - 32) * 5 / 9;
                labelResult.Text = "Результат: " + c.ToString("F2") + " °C";
            }
            catch (FormatException)
            {
                labelResult.Text = "Неверный ввод!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
