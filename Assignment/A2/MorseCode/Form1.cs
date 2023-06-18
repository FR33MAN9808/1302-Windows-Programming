using System.Security.Cryptography.X509Certificates;

namespace MorseCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> morseCodeDictionary;
            morseCodeDictionary = new Dictionary<char, string>
            {
                {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
                {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
                {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
                {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
                {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
                {'Z', "--.."},{'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
                {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
                {'.', ".-.-.-"}, {',', "--..--"}, {'?', "..--.."}, {' ', " "}
            };
            string inputStr = InputTextBox.Text.ToUpper();
            string result = "";
            foreach (char c in inputStr)
            {
                if (morseCodeDictionary.ContainsKey(c))
                {
                    result += morseCodeDictionary[c] + "/";
                }
                else
                {
                    result += " ";
                }
            }
            outputTextBox.Text = result;
        }
    }
}