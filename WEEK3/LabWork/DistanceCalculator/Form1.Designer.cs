namespace DistanceCalculator
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
            speedBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            hourBox = new TextBox();
            listBox1 = new ListBox();
            calculateButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // speedBox
            // 
            speedBox.Location = new Point(373, 68);
            speedBox.Name = "speedBox";
            speedBox.Size = new Size(150, 30);
            speedBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 71);
            label1.Name = "label1";
            label1.Size = new Size(204, 24);
            label1.TabIndex = 1;
            label1.Text = "Vehicle Speed in MPH:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 126);
            label2.Name = "label2";
            label2.Size = new Size(135, 24);
            label2.TabIndex = 2;
            label2.Text = "Hour Traveled:";
            // 
            // hourBox
            // 
            hourBox.Location = new Point(373, 126);
            hourBox.Name = "hourBox";
            hourBox.Size = new Size(150, 30);
            hourBox.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(117, 263);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(406, 316);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.ActiveBorder;
            calculateButton.Location = new Point(156, 202);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 34);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ActiveBorder;
            exitButton.Location = new Point(373, 202);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 626);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(listBox1);
            Controls.Add(hourBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(speedBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button calculateButton;
        private Button exitButton;
        public TextBox speedBox;
        public TextBox hourBox;
    }
}