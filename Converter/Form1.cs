using Krypton.Toolkit;

namespace Converter
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            kryptonTextBox2.Text = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(kryptonTextBox1.Text));
        }

        private void kryptonHeader1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                kryptonTextBox1.Text = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(kryptonTextBox2.Text));
            }
            catch
            {
                kryptonTextBox2.Text = "Invalid";
            }
        }
    }
}
