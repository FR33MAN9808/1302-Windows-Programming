namespace A1_RandomNumFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = null;
            int count = 0;
            int sum = 0;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog1.FileName);
            }
            while (inputFile.EndOfStream == false)
            {
                string line = inputFile.ReadLine();
                listBox1.Items.Add(line);
                sum += int.Parse(line);
                count++;
            }
            inputFile.Close();
            sumBox.Text = sum.ToString();
            numBox.Text = count.ToString();
        }
    }
}