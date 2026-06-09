namespace blood_donation
{
    partial class ManagerView
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            txtPhone = new TextBox();
            txtPass = new TextBox();
            txtName = new TextBox();
            rdfemale = new RadioButton();
            rd_male = new RadioButton();
            lbl_pass = new Label();
            lbl_phone = new Label();
            lbl_name = new Label();
            panel3 = new Panel();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(1, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 492);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(675, 486);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.FillWeight = 200F;
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 225;
            // 
            // Column2
            // 
            Column2.FillWeight = 140F;
            Column2.HeaderText = "Phone";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.HeaderText = "Password";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Gender";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(rdfemale);
            panel2.Controls.Add(rd_male);
            panel2.Controls.Add(lbl_pass);
            panel2.Controls.Add(lbl_phone);
            panel2.Controls.Add(lbl_name);
            panel2.Location = new Point(685, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 492);
            panel2.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(96, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(223, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(96, 176);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(223, 27);
            txtPass.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(96, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 27);
            txtName.TabIndex = 5;
            // 
            // rdfemale
            // 
            rdfemale.AutoSize = true;
            rdfemale.Location = new Point(152, 216);
            rdfemale.Name = "rdfemale";
            rdfemale.Size = new Size(78, 24);
            rdfemale.TabIndex = 4;
            rdfemale.TabStop = true;
            rdfemale.Text = "Female";
            rdfemale.UseVisualStyleBackColor = true;
            // 
            // rd_male
            // 
            rd_male.AutoSize = true;
            rd_male.Location = new Point(83, 216);
            rd_male.Name = "rd_male";
            rd_male.Size = new Size(63, 24);
            rd_male.TabIndex = 3;
            rd_male.TabStop = true;
            rd_male.Text = "Male";
            rd_male.UseVisualStyleBackColor = true;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new Point(18, 176);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(72, 20);
            lbl_pass.TabIndex = 2;
            lbl_pass.Text = "password";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(40, 135);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(50, 20);
            lbl_phone.TabIndex = 1;
            lbl_phone.Text = "Phone";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(44, 96);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(46, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "name";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnAdd);
            panel3.Location = new Point(14, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1020, 118);
            panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(693, 42);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Location = new Point(548, 42);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(399, 42);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(255, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ManagerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 634);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManagerView";
            Text = "ManagerView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbl_phone;
        private Panel panel3;
        private Label lbl_pass;
        private Label lbl_name;
        private TextBox txtPhone;
        private TextBox txtPass;
        private TextBox txtName;
        private RadioButton rdfemale;
        private RadioButton rd_male;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnClear;
        private Button btnAdd;
    }
}