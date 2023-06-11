namespace A1_RandomNumFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            StreamWriter outputFile = null;

            int numNum = int.Parse(textBox1.Text);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog1.FileName);

                for (int i = 0; i < numNum; i++)
                {
                    outputFile.Write($"{rand.Next(0, 100)}-");
                }

                outputFile.Close(); // Close the file after writing
               // Optionally, display a message indicating the successful generation of random numbers
                MessageBox.Show("Random numbers generated and saved successfully.");
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}