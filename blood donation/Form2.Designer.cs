namespace blood_donation
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSearchDonor = new Button();
            btnDonor = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel4 = new Panel();
            panel5 = new Panel();
            btnOk = new Button();
            txtShowDisease = new TextBox();
            lblDisease = new Label();
            soName = new Label();
            txtGender = new TextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblGender = new Label();
            txtNumber = new TextBox();
            txtName = new TextBox();
            lblNumber = new Label();
            lblName = new Label();
            dataGridView1 = new DataGridView();
            txtBG = new TextBox();
            lblBG = new Label();
            txtLocation = new TextBox();
            lblLocation = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(917, 37);
            label1.Name = "label1";
            label1.Size = new Size(237, 46);
            label1.TabIndex = 1;
            label1.Text = "Blood lagbe?";
            // 
            // button1
            // 
            button1.Location = new Point(784, 33);
            button1.Name = "button1";
            button1.Size = new Size(150, 48);
            button1.TabIndex = 2;
            button1.Text = "Search Donor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1741, 40);
            button4.Name = "button4";
            button4.Size = new Size(150, 48);
            button4.TabIndex = 23;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            tableLayoutPanel1.Size = new Size(1924, 125);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1918, 119);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 930);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1924, 125);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtLocation);
            panel2.Controls.Add(lblLocation);
            panel2.Controls.Add(txtBG);
            panel2.Controls.Add(lblBG);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1918, 119);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnSearchDonor);
            panel3.Controls.Add(btnDonor);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 805);
            panel3.TabIndex = 26;
            // 
            // btnSearchDonor
            // 
            btnSearchDonor.FlatAppearance.BorderSize = 0;
            btnSearchDonor.FlatStyle = FlatStyle.Flat;
            btnSearchDonor.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearchDonor.Location = new Point(49, 92);
            btnSearchDonor.Name = "btnSearchDonor";
            btnSearchDonor.Size = new Size(157, 29);
            btnSearchDonor.TabIndex = 1;
            btnSearchDonor.Text = "Search Donor";
            btnSearchDonor.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchDonor.UseVisualStyleBackColor = true;
            // 
            // btnDonor
            // 
            btnDonor.FlatAppearance.BorderSize = 0;
            btnDonor.FlatStyle = FlatStyle.Flat;
            btnDonor.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnDonor.Location = new Point(49, 36);
            btnDonor.Name = "btnDonor";
            btnDonor.Size = new Size(128, 29);
            btnDonor.TabIndex = 0;
            btnDonor.Text = "Add Donor";
            btnDonor.TextAlign = ContentAlignment.MiddleLeft;
            btnDonor.UseVisualStyleBackColor = true;
            btnDonor.Click += btnDonor_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(244, 125);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1680, 805);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1674, 799);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnOk);
            panel5.Controls.Add(txtShowDisease);
            panel5.Controls.Add(lblDisease);
            panel5.Controls.Add(soName);
            panel5.Controls.Add(txtGender);
            panel5.Controls.Add(txtAddress);
            panel5.Controls.Add(lblAddress);
            panel5.Controls.Add(lblGender);
            panel5.Controls.Add(txtNumber);
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(lblNumber);
            panel5.Controls.Add(lblName);
            panel5.Location = new Point(646, 223);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 467);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(152, 423);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 66;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtShowDisease
            // 
            txtShowDisease.BorderStyle = BorderStyle.FixedSingle;
            txtShowDisease.Location = new Point(15, 302);
            txtShowDisease.Multiline = true;
            txtShowDisease.Name = "txtShowDisease";
            txtShowDisease.ReadOnly = true;
            txtShowDisease.Size = new Size(373, 115);
            txtShowDisease.TabIndex = 65;
            // 
            // lblDisease
            // 
            lblDisease.AutoSize = true;
            lblDisease.Location = new Point(37, 267);
            lblDisease.Name = "lblDisease";
            lblDisease.Size = new Size(73, 22);
            lblDisease.TabIndex = 64;
            lblDisease.Text = "Disease";
            // 
            // soName
            // 
            soName.AutoSize = true;
            soName.BackColor = Color.Transparent;
            soName.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            soName.ForeColor = Color.Red;
            soName.Location = new Point(86, 32);
            soName.Name = "soName";
            soName.Size = new Size(237, 46);
            soName.TabIndex = 63;
            soName.Text = "Blood lagbe?";
            soName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGender
            // 
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Location = new Point(100, 217);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(288, 30);
            txtGender.TabIndex = 62;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(100, 181);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(288, 30);
            txtAddress.TabIndex = 61;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.ForeColor = SystemColors.ActiveCaptionText;
            lblAddress.Location = new Point(7, 183);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 22);
            lblAddress.TabIndex = 60;
            lblAddress.Text = "Address :";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Location = new Point(15, 219);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(79, 22);
            lblGender.TabIndex = 57;
            lblGender.Text = "Gender :";
            // 
            // txtNumber
            // 
            txtNumber.BorderStyle = BorderStyle.FixedSingle;
            txtNumber.Location = new Point(100, 145);
            txtNumber.Name = "txtNumber";
            txtNumber.ReadOnly = true;
            txtNumber.Size = new Size(288, 30);
            txtNumber.TabIndex = 55;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(100, 112);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(288, 30);
            txtName.TabIndex = 54;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Location = new Point(10, 147);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(84, 22);
            lblNumber.TabIndex = 52;
            lblNumber.Text = "Number :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Location = new Point(27, 114);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 22);
            lblName.TabIndex = 51;
            lblName.Text = "Name :";
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1672, 797);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtBG
            // 
            txtBG.BorderStyle = BorderStyle.FixedSingle;
            txtBG.Location = new Point(161, 40);
            txtBG.Name = "txtBG";
            txtBG.Size = new Size(88, 30);
            txtBG.TabIndex = 47;
            // 
            // lblBG
            // 
            lblBG.AutoSize = true;
            lblBG.BackColor = Color.Transparent;
            lblBG.Location = new Point(30, 43);
            lblBG.Name = "lblBG";
            lblBG.Size = new Size(125, 22);
            lblBG.TabIndex = 46;
            lblBG.Text = "Blood Group :";
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Location = new Point(443, 44);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(324, 30);
            txtLocation.TabIndex = 49;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Location = new Point(272, 46);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(165, 22);
            lblLocation.TabIndex = 48;
            lblLocation.Text = "District / Upozilla :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Account create";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Button btnSearchDonor;
        private Button btnDonor;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblGender;
        private TextBox txtNumber;
        private TextBox txtName;
        private Label lblNumber;
        private Label lblName;
        private TextBox txtGender;
        private Label lblDisease;
        private Label soName;
        private Button btnOk;
        private TextBox txtShowDisease;
        private TextBox txtLocation;
        private Label lblLocation;
        private TextBox txtBG;
        private Label lblBG;
    }
}