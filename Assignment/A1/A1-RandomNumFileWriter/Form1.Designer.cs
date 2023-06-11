namespace A1_RandomNumFileWriter
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
            label1 = new Label();
            textBox1 = new TextBox();
            exitButton = new Button();
            generateButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 90);
            label1.Name = "label1";
            label1.Size = new Size(265, 24);
            label1.TabIndex = 0;
            label1.Text = "# of random numbers(1-100):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(200, 424);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(200, 369);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(112, 34);
            generateButton.TabIndex = 3;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 490);
            Controls.Add(generateButton);
            Controls.Add(exitButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Random Number File Writter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button exitButton;
        private Button generateButton;
        private SaveFileDialog saveFileDialog1;
    }
}