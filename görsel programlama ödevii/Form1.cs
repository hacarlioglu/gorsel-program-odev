namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yaricap = 0;
            yaricap = Convert.ToInt32(textBox1.Text);

            int alan = 3 * yaricap * yaricap;
            label3.Text = Convert.ToString(alan);

            int cevre = 2 * 3 * yaricap;
            label5.Text = Convert.ToString(cevre);

        }
    }
}