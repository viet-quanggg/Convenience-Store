namespace Convenience_Store
{
    partial class AccountSetting
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
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnExit = new Button();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtPassword = new TextBox();
            dtpDOB = new DateTimePicker();
            txtName1 = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            panel3 = new Panel();
            txtRole1 = new TextBox();
            txtId1 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtRole = new TextBox();
            txtName2 = new TextBox();
            txtId = new TextBox();
            label12 = new Label();
            btnLogout = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 99);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(293, 18);
            label2.Name = "label2";
            label2.Size = new Size(358, 60);
            label2.TabIndex = 19;
            label2.Text = "Account Setting";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 465);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 79);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(797, 41);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 20;
            label3.Text = "Setting Page";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(28, 38);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(26, 14);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 4;
            label4.Text = "Id :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(378, 64);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Name :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(378, 111);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 4;
            label7.Text = "Password :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(378, 160);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 4;
            label8.Text = "Date of Birth :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(377, 206);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 4;
            label9.Text = "Phone :";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(378, 252);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 4;
            label10.Text = "Role :";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(378, 297);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 4;
            label11.Text = "Address :";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(485, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 5;
            // 
            // dtpDOB
            // 
            dtpDOB.Anchor = AnchorStyles.None;
            dtpDOB.Location = new Point(485, 155);
            dtpDOB.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpDOB.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(259, 27);
            dtpDOB.TabIndex = 6;
            // 
            // txtName1
            // 
            txtName1.Anchor = AnchorStyles.None;
            txtName1.Location = new Point(485, 61);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(125, 27);
            txtName1.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.Location = new Point(485, 294);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Location = new Point(485, 203);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(txtRole);
            panel3.Controls.Add(txtRole1);
            panel3.Controls.Add(txtId1);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dtpDOB);
            panel3.Controls.Add(txtName2);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtName1);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(920, 366);
            panel3.TabIndex = 8;
            // 
            // txtRole1
            // 
            txtRole1.Anchor = AnchorStyles.None;
            txtRole1.BackColor = SystemColors.MenuBar;
            txtRole1.BorderStyle = BorderStyle.FixedSingle;
            txtRole1.Location = new Point(485, 250);
            txtRole1.Name = "txtRole1";
            txtRole1.ReadOnly = true;
            txtRole1.Size = new Size(125, 27);
            txtRole1.TabIndex = 10;
            // 
            // txtId1
            // 
            txtId1.Anchor = AnchorStyles.None;
            txtId1.BackColor = SystemColors.MenuBar;
            txtId1.BorderStyle = BorderStyle.FixedSingle;
            txtId1.Location = new Point(485, 12);
            txtId1.Name = "txtId1";
            txtId1.ReadOnly = true;
            txtId1.Size = new Size(125, 27);
            txtId1.TabIndex = 9;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(378, 14);
            label13.Name = "label13";
            label13.Size = new Size(29, 20);
            label13.TabIndex = 8;
            label13.Text = "Id :";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(26, 111);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 8;
            label14.Text = "Role :";
            // 
            // txtRole
            // 
            txtRole.Anchor = AnchorStyles.None;
            txtRole.Enabled = false;
            txtRole.Location = new Point(99, 108);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(125, 27);
            txtRole.TabIndex = 7;
            // 
            // txtName2
            // 
            txtName2.Anchor = AnchorStyles.None;
            txtName2.Enabled = false;
            txtName2.Location = new Point(99, 64);
            txtName2.Name = "txtName2";
            txtName2.ReadOnly = true;
            txtName2.Size = new Size(125, 27);
            txtName2.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.BackColor = SystemColors.MenuBar;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(99, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 7;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(26, 64);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 6;
            label12.Text = "Name :";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(666, 308);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 39);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(797, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 39);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AccountSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 544);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AccountSetting";
            Text = "AccountSetting";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button btnExit;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtPassword;
        private DateTimePicker dtpDOB;
        private ComboBox cbRole;
        private TextBox txtName1;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Panel panel3;
        private Label label13;
        private Label label14;
        private TextBox txtRole;
        private TextBox txtName2;
        private TextBox txtId;
        private Label label12;
        private Button btnLogout;
        private Button btnSave;
        private TextBox txtId1;
        private TextBox txtRole1;
    }
}