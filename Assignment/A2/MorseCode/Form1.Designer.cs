namespace MorseCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            InputTextBox = new RichTextBox();
            ConvertButton = new Button();
            outputTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(71, 65);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(221, 364);
            InputTextBox.TabIndex = 1;
            InputTextBox.Text = "";
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(321, 200);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(112, 34);
            ConvertButton.TabIndex = 2;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(469, 65);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(249, 364);
            outputTextBox.TabIndex = 3;
            outputTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputTextBox);
            Controls.Add(ConvertButton);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "MorseCodeConverter";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox InputTextBox;
        private Button ConvertButton;
        private RichTextBox outputTextBox;
    }
}