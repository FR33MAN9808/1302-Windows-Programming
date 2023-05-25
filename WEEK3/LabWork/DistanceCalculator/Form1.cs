namespace DistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double speed = double.Parse(speedBox.Text);
            int hour = int.Parse(hourBox.Text);

            for (int i = 1; i <= hour; i++)
            {
                listBox1.Items.Add($"After hour {i}, the distance is {speed * i} mile");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}