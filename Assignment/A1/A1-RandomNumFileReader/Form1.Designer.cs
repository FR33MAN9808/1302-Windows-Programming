namespace A1_RandomNumFileReader
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
            OpenFileButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            listBox1 = new ListBox();
            label1 = new Label();
            ExitButton = new Button();
            label2 = new Label();
            label3 = new Label();
            sumBox = new TextBox();
            numBox = new TextBox();
            SuspendLayout();
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(64, 160);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(112, 34);
            OpenFileButton.TabIndex = 0;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(236, 74);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 364);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 34);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 2;
            label1.Text = "Results:";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(64, 257);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 160);
            label2.Name = "label2";
            label2.Size = new Size(52, 24);
            label2.TabIndex = 4;
            label2.Text = "Sum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 257);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 5;
            label3.Text = "# of Num:";
            // 
            // sumBox
            // 
            sumBox.Location = new Point(596, 162);
            sumBox.Name = "sumBox";
            sumBox.ReadOnly = true;
            sumBox.Size = new Size(150, 30);
            sumBox.TabIndex = 6;
            // 
            // numBox
            // 
            numBox.Location = new Point(596, 251);
            numBox.Name = "numBox";
            numBox.ReadOnly = true;
            numBox.Size = new Size(150, 30);
            numBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numBox);
            Controls.Add(sumBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ExitButton);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(OpenFileButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenFileButton;
        private OpenFileDialog openFileDialog1;
        private ListBox listBox1;
        private Label label1;
        private Button ExitButton;
        private Label label2;
        private Label label3;
        private TextBox sumBox;
        private TextBox numBox;
    }
}