namespace A2_DriverExam
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

        private void importFileButton_Click(object sender, EventArgs e)
        {
            string[] answerArr = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
            OpenFileDialog openFile = new OpenFileDialog();
            StreamReader inputFile = null;
            int count = 0;
            const int total = 20;
            int i = 0;
            string[] userAnswer = new string[20];
            DetailBox.Items.Add("#\tAttempt\tAnswer");

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
            }

            while (inputFile.ReadLine != null && i <= 19)
            {
                userAnswer[i] = inputFile.ReadLine();
                i++;
            }

            for (int j = 0; j < answerArr.Length; j++)
            {
                if (answerArr[j] == userAnswer[j])
                {
                    count++;
                }
                else
                {
                    DetailBox.Items.Add($"{j + 1}\t{userAnswer[j]}\t{answerArr[j]}");
                }
            }
            ScoreBox.Text = ($"{count}/{total}");
            if (count >= 15)
            {
                MessageBox.Show("You passed the exam, well done!");
            }
            else
            {
                MessageBox.Show("You failed, good luck next time.");
            }
        }
    }
}