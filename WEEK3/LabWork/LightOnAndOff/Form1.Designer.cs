namespace LightOnAndOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lightOff = new PictureBox();
            lightOn = new PictureBox();
            textBox1 = new TextBox();
            switchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)lightOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lightOn).BeginInit();
            SuspendLayout();
            // 
            // lightOff
            // 
            lightOff.Image = (Image)resources.GetObject("lightOff.Image");
            lightOff.Location = new Point(337, 12);
            lightOff.Name = "lightOff";
            lightOff.Size = new Size(329, 440);
            lightOff.SizeMode = PictureBoxSizeMode.AutoSize;
            lightOff.TabIndex = 0;
            lightOff.TabStop = false;
            lightOff.Visible = false;
            lightOff.Click += pictureBox1_Click;
            // 
            // lightOn
            // 
            lightOn.Image = (Image)resources.GetObject("lightOn.Image");
            lightOn.Location = new Point(337, 12);
            lightOn.Name = "lightOn";
            lightOn.Size = new Size(329, 440);
            lightOn.SizeMode = PictureBoxSizeMode.AutoSize;
            lightOn.TabIndex = 1;
            lightOn.TabStop = false;
            lightOn.Click += lightOn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(427, 484);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 38);
            textBox1.TabIndex = 2;
            textBox1.Text = "ON";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // switchButton
            // 
            switchButton.BackColor = Color.Silver;
            switchButton.FlatAppearance.BorderColor = Color.DimGray;
            switchButton.FlatStyle = FlatStyle.Popup;
            switchButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            switchButton.Location = new Point(449, 580);
            switchButton.Name = "switchButton";
            switchButton.Size = new Size(112, 34);
            switchButton.TabIndex = 3;
            switchButton.Text = "Switch";
            switchButton.UseVisualStyleBackColor = false;
            switchButton.Click += switchButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 657);
            Controls.Add(switchButton);
            Controls.Add(textBox1);
            Controls.Add(lightOn);
            Controls.Add(lightOff);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)lightOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)lightOn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox lightOff;
        private PictureBox lightOn;
        private TextBox textBox1;
        private Button switchButton;
    }
}