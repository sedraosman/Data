namespace DairyFarmSystem
{
    partial class MilkProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MilkProduction));
            CowIdCb = new ComboBox();
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
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Date = new DateTimePicker();
            Cownametb = new TextBox();
            Amt = new TextBox();
            TotalTb = new TextBox();
            PmTb = new TextBox();
            noonTb = new TextBox();
            panel1 = new Panel();
            label10 = new Label();
            panel8 = new Panel();
            label16 = new Label();
            panel7 = new Panel();
            label15 = new Label();
            panel6 = new Panel();
            label14 = new Label();
            panel5 = new Panel();
            label13 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            MilkDGV = new DataGridView();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MilkDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CowIdCb
            // 
            CowIdCb.FormattingEnabled = true;
            CowIdCb.Location = new Point(235, 92);
            CowIdCb.Name = "CowIdCb";
            CowIdCb.Size = new Size(196, 28);
            CowIdCb.TabIndex = 95;
            CowIdCb.SelectedIndexChanged += CowIdCb_SelectedIndexChanged;
            CowIdCb.SelectionChangeCommitted += CowIdCb_SelectionChangeCommitted;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(654, 9);
            label17.Name = "label17";
            label17.Size = new Size(128, 31);
            label17.TabIndex = 94;
            label17.Text = "Daily Milk";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1329, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 93;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(1200, 210);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 92;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1200, 154);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 91;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1200, 101);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 90;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1200, 49);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 89;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(665, 210);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 88;
            label9.Text = "Daily Milk";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(233, 64);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 86;
            label8.Text = "Cow Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(447, 64);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 85;
            label7.Text = "Cow Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(665, 64);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 84;
            label6.Text = "Am Milk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(886, 64);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 83;
            label5.Text = "Noon Milk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(233, 122);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 82;
            label4.Text = "Pm Milke";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(447, 125);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 81;
            label2.Text = "Total Milke";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(665, 125);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 80;
            label1.Text = "Date";
            // 
            // Date
            // 
            Date.Location = new Point(665, 153);
            Date.Name = "Date";
            Date.Size = new Size(198, 27);
            Date.TabIndex = 79;
            // 
            // Cownametb
            // 
            Cownametb.Enabled = false;
            Cownametb.Location = new Point(447, 92);
            Cownametb.Name = "Cownametb";
            Cownametb.Size = new Size(200, 27);
            Cownametb.TabIndex = 78;
            Cownametb.TextChanged += Cownametb_TextChanged;
            // 
            // Amt
            // 
            Amt.Location = new Point(665, 92);
            Amt.Name = "Amt";
            Amt.Size = new Size(183, 27);
            Amt.TabIndex = 77;
            Amt.TextChanged += Amt_TextChanged;
            // 
            // TotalTb
            // 
            TotalTb.Enabled = false;
            TotalTb.Location = new Point(447, 153);
            TotalTb.Name = "TotalTb";
            TotalTb.Size = new Size(200, 27);
            TotalTb.TabIndex = 76;
            TotalTb.TextChanged += TotalTb_TextChanged;
            // 
            // PmTb
            // 
            PmTb.Location = new Point(235, 153);
            PmTb.Name = "PmTb";
            PmTb.Size = new Size(206, 27);
            PmTb.TabIndex = 96;
            PmTb.TextChanged += PmTb_TextChanged;
            PmTb.Leave += PmTb_Leave;
            // 
            // noonTb
            // 
            noonTb.Location = new Point(886, 92);
            noonTb.Name = "noonTb";
            noonTb.Size = new Size(200, 27);
            noonTb.TabIndex = 74;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-6, -25);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 599);
            panel1.TabIndex = 73;
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
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Controls.Add(label16);
            panel8.Location = new Point(0, 480);
            panel8.Name = "panel8";
            panel8.Size = new Size(235, 32);
            panel8.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(32, 2);
            label16.Name = "label16";
            label16.Size = new Size(101, 25);
            label16.TabIndex = 17;
            label16.Text = "Dashboard";
            // 
            // panel7
            // 
            panel7.Controls.Add(label15);
            panel7.Location = new Point(0, 419);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 32);
            panel7.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(32, 2);
            label15.Name = "label15";
            label15.Size = new Size(75, 25);
            label15.TabIndex = 17;
            label15.Text = "Finance";
            // 
            // panel6
            // 
            panel6.Controls.Add(label14);
            panel6.Location = new Point(0, 360);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 32);
            panel6.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(32, 2);
            label14.Name = "label14";
            label14.Size = new Size(95, 25);
            label14.TabIndex = 17;
            label14.Text = "Milk Sales";
            // 
            // panel5
            // 
            panel5.Controls.Add(label13);
            panel5.Location = new Point(0, 297);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 32);
            panel5.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(32, 2);
            label13.Name = "label13";
            label13.Size = new Size(88, 25);
            label13.TabIndex = 17;
            label13.Text = "Breeding";
            // 
            // panel4
            // 
            panel4.Controls.Add(label12);
            panel4.Location = new Point(0, 237);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 32);
            panel4.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(32, 2);
            label12.Name = "label12";
            label12.Size = new Size(66, 25);
            label12.TabIndex = 17;
            label12.Text = "Health";
            label12.Click += label12_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 173);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 32);
            panel3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 5);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 18;
            label3.Text = "Milke Proudtion";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label11);
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 32);
            panel2.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(32, 2);
            label11.Name = "label11";
            label11.Size = new Size(56, 25);
            label11.TabIndex = 17;
            label11.Text = "Cows";
            label11.Click += label11_Click;
            // 
            // MilkDGV
            // 
            MilkDGV.ColumnHeadersHeight = 29;
            MilkDGV.Location = new Point(233, 265);
            MilkDGV.Name = "MilkDGV";
            MilkDGV.RowHeadersWidth = 51;
            MilkDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MilkDGV.Size = new Size(1221, 309);
            MilkDGV.TabIndex = 0;
            MilkDGV.CellContentClick += MilkDGV_CellContentClick_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1443, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 122;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // MilkProduction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 595);
            Controls.Add(pictureBox2);
            Controls.Add(MilkDGV);
            Controls.Add(CowIdCb);
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
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Date);
            Controls.Add(Cownametb);
            Controls.Add(Amt);
            Controls.Add(TotalTb);
            Controls.Add(PmTb);
            Controls.Add(noonTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MilkProduction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MilkeProduction";
            Load += MilkProduction_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MilkDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MilkDGV_CellContentClick(object sender,
            DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox CowIdCb;
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
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker Date;
        private TextBox Cownametb;
        private TextBox Amt;
        private TextBox TotalTb;
        private TextBox PmTb;
        private TextBox noonTb;
        private Panel panel1;
        private Label label10;
        private Panel panel8;
        private Label label16;
        private Panel panel7;
        private Label label15;
        private Panel panel6;
        private Label label14;
        private Panel panel5;
        private Label label13;
        private Panel panel4;
        private Label label12;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label11;
        private DataGridView MilkDGV;
        private PictureBox pictureBox2;
    }
}