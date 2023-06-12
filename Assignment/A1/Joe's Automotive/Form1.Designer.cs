namespace Joe_s_Automotive
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
            groupBox1 = new GroupBox();
            lubeJob = new CheckBox();
            oilChange = new CheckBox();
            groupBox2 = new GroupBox();
            transmissionBox = new CheckBox();
            radiatorFlush = new CheckBox();
            groupBox3 = new GroupBox();
            tireBox = new CheckBox();
            mufflerBox = new CheckBox();
            inspectionBox = new CheckBox();
            groupBox4 = new GroupBox();
            laborBox = new TextBox();
            partBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            totalFeeBox = new TextBox();
            taxBox = new TextBox();
            partFeeBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            serviceFeeBox = new TextBox();
            Calculatebutton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lubeJob);
            groupBox1.Controls.Add(oilChange);
            groupBox1.Location = new Point(44, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oil and Lube";
            // 
            // lubeJob
            // 
            lubeJob.AutoSize = true;
            lubeJob.Location = new Point(43, 103);
            lubeJob.Name = "lubeJob";
            lubeJob.Size = new Size(184, 28);
            lubeJob.TabIndex = 1;
            lubeJob.Text = "Lube Job($18.00)";
            lubeJob.UseVisualStyleBackColor = true;
            // 
            // oilChange
            // 
            oilChange.AutoSize = true;
            oilChange.Location = new Point(43, 49);
            oilChange.Name = "oilChange";
            oilChange.Size = new Size(203, 28);
            oilChange.TabIndex = 0;
            oilChange.Text = "Oil Change($26.00)";
            oilChange.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(transmissionBox);
            groupBox2.Controls.Add(radiatorFlush);
            groupBox2.Location = new Point(393, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 142);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Flushes";
            // 
            // transmissionBox
            // 
            transmissionBox.AutoSize = true;
            transmissionBox.Location = new Point(31, 103);
            transmissionBox.Name = "transmissionBox";
            transmissionBox.Size = new Size(268, 28);
            transmissionBox.TabIndex = 1;
            transmissionBox.Text = "Transmission Flush($80.00)";
            transmissionBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlush
            // 
            radiatorFlush.AutoSize = true;
            radiatorFlush.Location = new Point(31, 49);
            radiatorFlush.Name = "radiatorFlush";
            radiatorFlush.Size = new Size(231, 28);
            radiatorFlush.TabIndex = 0;
            radiatorFlush.Text = "Radiator Flush($30.00)";
            radiatorFlush.UseVisualStyleBackColor = true;
            radiatorFlush.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tireBox);
            groupBox3.Controls.Add(mufflerBox);
            groupBox3.Controls.Add(inspectionBox);
            groupBox3.Location = new Point(44, 218);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 150);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Misc";
            // 
            // tireBox
            // 
            tireBox.AutoSize = true;
            tireBox.Location = new Point(43, 97);
            tireBox.Name = "tireBox";
            tireBox.Size = new Size(218, 28);
            tireBox.TabIndex = 2;
            tireBox.Text = "Tire Rotation($20.00)";
            tireBox.UseVisualStyleBackColor = true;
            // 
            // mufflerBox
            // 
            mufflerBox.AutoSize = true;
            mufflerBox.Location = new Point(43, 63);
            mufflerBox.Name = "mufflerBox";
            mufflerBox.Size = new Size(254, 28);
            mufflerBox.TabIndex = 1;
            mufflerBox.Text = "Replace Muffler($100.00)";
            mufflerBox.UseVisualStyleBackColor = true;
            // 
            // inspectionBox
            // 
            inspectionBox.AutoSize = true;
            inspectionBox.Location = new Point(43, 29);
            inspectionBox.Name = "inspectionBox";
            inspectionBox.Size = new Size(196, 28);
            inspectionBox.TabIndex = 0;
            inspectionBox.Text = "Inspection($15.00)";
            inspectionBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(laborBox);
            groupBox4.Controls.Add(partBox);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(393, 218);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 150);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parts and Labor";
            // 
            // laborBox
            // 
            laborBox.Location = new Point(131, 83);
            laborBox.Name = "laborBox";
            laborBox.Size = new Size(150, 30);
            laborBox.TabIndex = 3;
            // 
            // partBox
            // 
            partBox.Location = new Point(131, 42);
            partBox.Name = "partBox";
            partBox.Size = new Size(150, 30);
            partBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 86);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 1;
            label2.Text = "Labor($)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(53, 24);
            label1.TabIndex = 0;
            label1.Text = "Parts";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(totalFeeBox);
            groupBox5.Controls.Add(taxBox);
            groupBox5.Controls.Add(partFeeBox);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(serviceFeeBox);
            groupBox5.Location = new Point(44, 394);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(649, 229);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Summary";
            // 
            // totalFeeBox
            // 
            totalFeeBox.Location = new Point(349, 187);
            totalFeeBox.Name = "totalFeeBox";
            totalFeeBox.ReadOnly = true;
            totalFeeBox.Size = new Size(150, 30);
            totalFeeBox.TabIndex = 7;
            // 
            // taxBox
            // 
            taxBox.Location = new Point(349, 142);
            taxBox.Name = "taxBox";
            taxBox.ReadOnly = true;
            taxBox.Size = new Size(150, 30);
            taxBox.TabIndex = 6;
            // 
            // partFeeBox
            // 
            partFeeBox.Location = new Point(349, 98);
            partFeeBox.Name = "partFeeBox";
            partFeeBox.ReadOnly = true;
            partFeeBox.Size = new Size(150, 30);
            partFeeBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 187);
            label6.Name = "label6";
            label6.Size = new Size(96, 24);
            label6.TabIndex = 4;
            label6.Text = "Total Fees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 142);
            label5.Name = "label5";
            label5.Size = new Size(122, 24);
            label5.TabIndex = 3;
            label5.Text = "Tax(on parts)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 98);
            label4.Name = "label4";
            label4.Size = new Size(53, 24);
            label4.TabIndex = 2;
            label4.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 48);
            label3.Name = "label3";
            label3.Size = new Size(162, 24);
            label3.TabIndex = 1;
            label3.Text = "Service and Labor";
            // 
            // serviceFeeBox
            // 
            serviceFeeBox.Location = new Point(349, 48);
            serviceFeeBox.Name = "serviceFeeBox";
            serviceFeeBox.ReadOnly = true;
            serviceFeeBox.Size = new Size(150, 30);
            serviceFeeBox.TabIndex = 0;
            serviceFeeBox.TextChanged += textBox1_TextChanged;
            // 
            // Calculatebutton
            // 
            Calculatebutton.Location = new Point(159, 651);
            Calculatebutton.Name = "Calculatebutton";
            Calculatebutton.Size = new Size(112, 34);
            Calculatebutton.TabIndex = 4;
            Calculatebutton.Text = "Calculate";
            Calculatebutton.UseVisualStyleBackColor = true;
            Calculatebutton.Click += Calculatebutton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(317, 651);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(486, 651);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 728);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(Calculatebutton);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Automotive";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox oilChange;
        private GroupBox groupBox2;
        private CheckBox lubeJob;
        private CheckBox transmissionBox;
        private CheckBox radiatorFlush;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private CheckBox tireBox;
        private CheckBox mufflerBox;
        private CheckBox inspectionBox;
        private TextBox laborBox;
        private TextBox partBox;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox serviceFeeBox;
        private TextBox totalFeeBox;
        private TextBox taxBox;
        private TextBox partFeeBox;
        private Button Calculatebutton;
        private Button ClearButton;
        private Button ExitButton;
    }
}