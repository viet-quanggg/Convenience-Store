namespace Convenience_Store
{
    partial class StaffManageForm
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
            label6 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            AllStaffDataGridView = new DataGridView();
            label2 = new Label();
            nametTxt = new TextBox();
            searchButton = new Button();
            label3 = new Label();
            txtName = new TextBox();
            txt = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            txtDob = new DateTimePicker();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtID = new TextBox();
            label8 = new Label();
            ExitButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllStaffDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(12, 14);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(338, 6);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 2;
            label1.Text = "Staff Manage";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 43);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "New Staff";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(321, 368);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(121, 43);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(464, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 43);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // AllStaffDataGridView
            // 
            AllStaffDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllStaffDataGridView.Location = new Point(374, 100);
            AllStaffDataGridView.Name = "AllStaffDataGridView";
            AllStaffDataGridView.RowHeadersWidth = 51;
            AllStaffDataGridView.RowTemplate.Height = 29;
            AllStaffDataGridView.Size = new Size(426, 251);
            AllStaffDataGridView.TabIndex = 7;
            AllStaffDataGridView.CellDoubleClick += AllStaffDataGridView_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 43);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 8;
            label2.Text = "Staff Infor";
            // 
            // nametTxt
            // 
            nametTxt.Location = new Point(374, 67);
            nametTxt.Name = "nametTxt";
            nametTxt.Size = new Size(328, 27);
            nametTxt.TabIndex = 9;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(708, 66);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(92, 28);
            searchButton.TabIndex = 10;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 128);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 11;
            label3.Text = "Account Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(234, 27);
            txtName.TabIndex = 12;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(0, 169);
            txt.Name = "txt";
            txt.Size = new Size(128, 20);
            txt.TabIndex = 13;
            txt.Text = "Account Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 210);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "Staff DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 255);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 15;
            label4.Text = "Staff Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 293);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 16;
            label7.Text = "Staff Address";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(134, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 27);
            txtPassword.TabIndex = 17;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(103, 203);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(265, 27);
            txtDob.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(134, 248);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(234, 27);
            txtPhone.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(134, 286);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(234, 27);
            txtAddress.TabIndex = 20;
            // 
            // txtID
            // 
            txtID.Location = new Point(134, 79);
            txtID.Name = "txtID";
            txtID.Size = new Size(234, 27);
            txtID.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 86);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 22;
            label8.Text = "Accout ID";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(725, 422);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 27);
            ExitButton.TabIndex = 23;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // StaffManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(label8);
            Controls.Add(txtID);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtDob);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txt);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(searchButton);
            Controls.Add(nametTxt);
            Controls.Add(label2);
            Controls.Add(AllStaffDataGridView);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Name = "StaffManageForm";
            Text = "StaffManageForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllStaffDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView AllStaffDataGridView;
        private Label label2;
        private TextBox nametTxt;
        private Button searchButton;
        private Label label3;
        private TextBox txtName;
        private Label txt;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox txtPassword;
        private DateTimePicker txtDob;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtID;
        private Label label8;
        private Button ExitButton;
    }
}