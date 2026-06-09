namespace blood_donation
{
    partial class Users
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            soName = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            dtpDate = new DateTimePicker();
            lblMonth = new Label();
            btnNo = new Button();
            btnYes = new Button();
            lblDoYou = new Label();
            gpDiseas = new GroupBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lblGender = new Label();
            txtBG = new TextBox();
            txtNumber = new TextBox();
            txtName = new TextBox();
            lblBG = new Label();
            lblNumber = new Label();
            lblName = new Label();
            panel2 = new Panel();
            lblDonationType = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            gpDiseas.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1831, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(soName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1825, 119);
            panel1.TabIndex = 0;
            // 
            // soName
            // 
            soName.AutoSize = true;
            soName.BackColor = Color.Transparent;
            soName.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            soName.ForeColor = Color.Red;
            soName.Location = new Point(800, 35);
            soName.Name = "soName";
            soName.Size = new Size(237, 46);
            soName.TabIndex = 2;
            soName.Text = "Blood lagbe?";
            soName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 901);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1831, 125);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnRefresh);
            panel5.Controls.Add(btnUpdate);
            panel5.Controls.Add(btnAdd);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1825, 119);
            panel5.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(1094, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Location = new Point(949, 52);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(800, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(656, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Controls.Add(panel4, 2, 0);
            tableLayoutPanel3.Controls.Add(panel3, 1, 0);
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 125);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1831, 776);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(885, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(943, 770);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 768);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(lblDonationType);
            panel3.Controls.Add(dtpDOB);
            panel3.Controls.Add(lblDOB);
            panel3.Controls.Add(dtpDate);
            panel3.Controls.Add(lblMonth);
            panel3.Controls.Add(btnNo);
            panel3.Controls.Add(btnYes);
            panel3.Controls.Add(lblDoYou);
            panel3.Controls.Add(gpDiseas);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(lblAddress);
            panel3.Controls.Add(rbFemale);
            panel3.Controls.Add(rbMale);
            panel3.Controls.Add(lblGender);
            panel3.Controls.Add(txtBG);
            panel3.Controls.Add(txtNumber);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(lblBG);
            panel3.Controls.Add(lblNumber);
            panel3.Controls.Add(lblName);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(253, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 770);
            panel3.TabIndex = 2;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(114, 190);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(267, 27);
            dtpDOB.TabIndex = 59;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BackColor = Color.Transparent;
            lblDOB.Location = new Point(7, 195);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(101, 20);
            lblDOB.TabIndex = 58;
            lblDOB.Text = "Date of Birth :";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(171, 465);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(267, 27);
            dtpDate.TabIndex = 57;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.BackColor = Color.Transparent;
            lblMonth.Location = new Point(117, 470);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(48, 20);
            lblMonth.TabIndex = 56;
            lblMonth.Text = "Date :";
            // 
            // btnNo
            // 
            btnNo.Location = new Point(386, 414);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 29);
            btnNo.TabIndex = 54;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(275, 414);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 29);
            btnYes.TabIndex = 53;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // lblDoYou
            // 
            lblDoYou.AutoSize = true;
            lblDoYou.BackColor = Color.Transparent;
            lblDoYou.Location = new Point(11, 421);
            lblDoYou.Name = "lblDoYou";
            lblDoYou.Size = new Size(207, 20);
            lblDoYou.TabIndex = 52;
            lblDoYou.Text = "Do you donate blood before?";
            // 
            // gpDiseas
            // 
            gpDiseas.Controls.Add(checkBox8);
            gpDiseas.Controls.Add(checkBox7);
            gpDiseas.Controls.Add(checkBox6);
            gpDiseas.Controls.Add(checkBox5);
            gpDiseas.Controls.Add(checkBox4);
            gpDiseas.Controls.Add(checkBox3);
            gpDiseas.Controls.Add(checkBox2);
            gpDiseas.Controls.Add(checkBox1);
            gpDiseas.Location = new Point(7, 234);
            gpDiseas.Name = "gpDiseas";
            gpDiseas.Size = new Size(583, 155);
            gpDiseas.TabIndex = 51;
            gpDiseas.TabStop = false;
            gpDiseas.Text = "Do you have diseases?";
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(421, 102);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(122, 24);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "Lung diseases";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(421, 47);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(133, 24);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "kidney diseases";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(289, 102);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(94, 24);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Diabeties";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(289, 47);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(81, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Malaria";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(161, 104);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(50, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Flu";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(161, 47);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(89, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Asthama";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(26, 102);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Jaundice";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Hepatities";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(114, 153);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(324, 27);
            txtAddress.TabIndex = 50;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.ForeColor = SystemColors.ActiveCaptionText;
            lblAddress.Location = new Point(39, 156);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 49;
            lblAddress.Text = "Address :";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(236, 123);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 48;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(143, 123);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 47;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Location = new Point(44, 125);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 20);
            lblGender.TabIndex = 46;
            lblGender.Text = "Gender :";
            // 
            // txtBG
            // 
            txtBG.BorderStyle = BorderStyle.FixedSingle;
            txtBG.Location = new Point(114, 89);
            txtBG.Name = "txtBG";
            txtBG.Size = new Size(324, 27);
            txtBG.TabIndex = 45;
            // 
            // txtNumber
            // 
            txtNumber.BorderStyle = BorderStyle.FixedSingle;
            txtNumber.Location = new Point(114, 56);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(324, 27);
            txtNumber.TabIndex = 43;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(114, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 27);
            txtName.TabIndex = 42;
            // 
            // lblBG
            // 
            lblBG.AutoSize = true;
            lblBG.BackColor = Color.Transparent;
            lblBG.Location = new Point(7, 92);
            lblBG.Name = "lblBG";
            lblBG.Size = new Size(101, 20);
            lblBG.TabIndex = 41;
            lblBG.Text = "Blood Group :";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Location = new Point(38, 59);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(70, 20);
            lblNumber.TabIndex = 39;
            lblNumber.Text = "Number :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Location = new Point(52, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 38;
            lblName.Text = "Name :";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 770);
            panel2.TabIndex = 1;
            // 
            // lblDonationType
            // 
            lblDonationType.AutoSize = true;
            lblDonationType.Location = new Point(20, 532);
            lblDonationType.Name = "lblDonationType";
            lblDonationType.Size = new Size(106, 20);
            lblDonationType.TabIndex = 60;
            lblDonationType.Text = "Donation Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Whole Blood", "Plasma", "Platelet" });
            comboBox1.Location = new Point(132, 532);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 61;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1831, 1026);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Users";
            Text = "Users";
            WindowState = FormWindowState.Maximized;
            Load += Users_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gpDiseas.ResumeLayout(false);
            gpDiseas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label soName;
        private Label lblGender;
        private TextBox txtBG;
        private TextBox txtNumber;
        private TextBox txtName;
        private Label lblBG;
        private Label lblNumber;
        private Label lblName;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtAddress;
        private Label lblAddress;
        private GroupBox gpDiseas;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btnNo;
        private Button btnYes;
        private Label lblDoYou;
        private DateTimePicker dtpDate;
        private Label lblMonth;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private ComboBox comboBox1;
        private Label lblDonationType;
    }
}