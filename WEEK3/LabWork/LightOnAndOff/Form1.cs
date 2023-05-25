namespace LightOnAndOff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            lightOff.Visible = !lightOff.Visible;
            lightOn.Visible = !lightOn.Visible;
            if (textBox1.Text == "ON")
            {
                textBox1.Text = "OFF";
            }
            else
            {
                textBox1.Text = "ON";
            }
        }

        private void lightOn_Click(object sender, EventArgs e)
        {

        }
    }
}