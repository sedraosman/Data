namespace DairyFarmSystem
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            label19 = new Label();
            DOB = new DateTimePicker();
            EmployeeDGV = new DataGridView();
            label18 = new Label();
            GenCb = new ComboBox();
            label17 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            EmpNameTb = new TextBox();
            PhoneTb = new TextBox();
            AdressTb = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(241, 147);
            label19.Name = "label19";
            label19.Size = new Size(50, 25);
            label19.TabIndex = 116;
            label19.Text = "DOB";
            // 
            // DOB
            // 
            DOB.Location = new Point(241, 175);
            DOB.Name = "DOB";
            DOB.Size = new Size(198, 27);
            DOB.TabIndex = 115;
            // 
            // EmployeeDGV
            // 
            EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDGV.Location = new Point(241, 286);
            EmployeeDGV.Name = "EmployeeDGV";
            EmployeeDGV.RowHeadersWidth = 51;
            EmployeeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeDGV.Size = new Size(1213, 312);
            EmployeeDGV.TabIndex = 114;
            EmployeeDGV.CellContentClick += EmployeeDGV_CellContentClick;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(455, 88);
            label18.Name = "label18";
            label18.Size = new Size(61, 25);
            label18.TabIndex = 113;
            label18.Text = "Name";
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Female", "Male" });
            GenCb.Location = new Point(241, 119);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(198, 28);
            GenCb.TabIndex = 112;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(673, 19);
            label17.Name = "label17";
            label17.Size = new Size(110, 31);
            label17.TabIndex = 111;
            label17.Text = "Emolyee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1338, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 110;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(1189, 220);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 109;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1189, 160);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 108;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1189, 103);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 107;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1189, 49);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 106;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(673, 224);
            label9.Name = "label9";
            label9.Size = new Size(103, 25);
            label9.TabIndex = 105;
            label9.Text = "Employees";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(241, 91);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 104;
            label8.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(455, 91);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 103;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(673, 91);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 102;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(894, 91);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 101;
            label5.Text = "Address";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(455, 119);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(200, 27);
            EmpNameTb.TabIndex = 96;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(673, 119);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(183, 27);
            PhoneTb.TabIndex = 95;
            // 
            // AdressTb
            // 
            AdressTb.Location = new Point(894, 119);
            AdressTb.Name = "AdressTb";
            AdressTb.Size = new Size(200, 27);
            AdressTb.TabIndex = 92;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 47);
            label10.Name = "label10";
            label10.Size = new Size(185, 25);
            label10.TabIndex = 25;
            label10.Text = "Dairy Farm Software";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label10);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 599);
            panel1.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(455, 149);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 118;
            label1.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(455, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 117;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1440, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 119;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 595);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label19);
            Controls.Add(DOB);
            Controls.Add(EmployeeDGV);
            Controls.Add(label18);
            Controls.Add(GenCb);
            Controls.Add(label17);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EmpNameTb);
            Controls.Add(PhoneTb);
            Controls.Add(AdressTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label19;
        private DateTimePicker DOB;
        private DataGridView EmployeeDGV;
        private Label label18;
        private ComboBox GenCb;
        private Label label17;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox EmpNameTb;
        private TextBox PhoneTb;
        private TextBox AdressTb;
        private Label label10;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox4;
    }
}