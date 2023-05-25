namespace PolulationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int starting;
            double increasingRate;
            int days;
            if (int.TryParse(startingBox.Text, out starting) && double.TryParse(rateBox.Text, out increasingRate) && int.TryParse(dayBox.Text, out days))
            {
                listBox1.Items.Add($"Day \t Population");
                double population = starting;
                double rate = increasingRate / 100;
                for (int i = 1; i <= days; i++)
                {
                    listBox1.Items.Add($"{i} \t {population}");
                    population =+ population * (1 + rate);
                }
            }
        }
    }
}