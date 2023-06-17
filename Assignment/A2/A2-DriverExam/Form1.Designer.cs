namespace A2_DriverExam
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
            importFileButton = new Button();
            label1 = new Label();
            ScoreBox = new TextBox();
            DetailBox = new ListBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // importFileButton
            // 
            importFileButton.Location = new Point(192, 12);
            importFileButton.Name = "importFileButton";
            importFileButton.Size = new Size(112, 34);
            importFileButton.TabIndex = 0;
            importFileButton.Text = "Import File";
            importFileButton.UseVisualStyleBackColor = true;
            importFileButton.Click += importFileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 1;
            // 
            // ScoreBox
            // 
            ScoreBox.Location = new Point(175, 60);
            ScoreBox.Name = "ScoreBox";
            ScoreBox.ReadOnly = true;
            ScoreBox.Size = new Size(150, 30);
            ScoreBox.TabIndex = 2;
            ScoreBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DetailBox
            // 
            DetailBox.FormattingEnabled = true;
            DetailBox.ItemHeight = 24;
            DetailBox.Location = new Point(46, 118);
            DetailBox.Name = "DetailBox";
            DetailBox.Size = new Size(387, 292);
            DetailBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(DetailBox);
            Controls.Add(ScoreBox);
            Controls.Add(label1);
            Controls.Add(importFileButton);
            Name = "Form1";
            Text = "Dirver Exam";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button importFileButton;
        private Label label1;
        private TextBox ScoreBox;
        private ListBox DetailBox;
    }
}