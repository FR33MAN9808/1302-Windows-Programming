namespace PolulationCalculator
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
            label2 = new Label();
            label3 = new Label();
            startingBox = new TextBox();
            rateBox = new TextBox();
            dayBox = new TextBox();
            calculateButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 48);
            label1.Name = "label1";
            label1.Size = new Size(246, 24);
            label1.TabIndex = 0;
            label1.Text = "Starting number organisms\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 107);
            label2.Name = "label2";
            label2.Size = new Size(203, 24);
            label2.TabIndex = 1;
            label2.Text = "Average daily increase\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 168);
            label3.Name = "label3";
            label3.Size = new Size(249, 24);
            label3.TabIndex = 2;
            label3.Text = "Number of days to multiply";
            // 
            // startingBox
            // 
            startingBox.Location = new Point(376, 45);
            startingBox.Name = "startingBox";
            startingBox.Size = new Size(195, 30);
            startingBox.TabIndex = 3;
            // 
            // rateBox
            // 
            rateBox.Location = new Point(376, 107);
            rateBox.Name = "rateBox";
            rateBox.Size = new Size(195, 30);
            rateBox.TabIndex = 4;
            // 
            // dayBox
            // 
            dayBox.Location = new Point(376, 168);
            dayBox.Name = "dayBox";
            dayBox.Size = new Size(195, 30);
            dayBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(241, 218);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 34);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(145, 269);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(333, 340);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 629);
            Controls.Add(listBox1);
            Controls.Add(calculateButton);
            Controls.Add(dayBox);
            Controls.Add(rateBox);
            Controls.Add(startingBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox startingBox;
        private TextBox rateBox;
        private TextBox dayBox;
        private Button calculateButton;
        private ListBox listBox1;
    }
}