namespace Convenience_Store
{
    partial class AddStaff
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
            label2 = new Label();
            txtPass = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtDob = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 131);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Account Name";
            // 
            // txtPass
            // 
            txtPass.AutoSize = true;
            txtPass.Location = new Point(48, 176);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(128, 20);
            txtPass.TabIndex = 2;
            txtPass.Text = "Account Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 223);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Staff DOB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 269);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 5;
            label6.Text = "Staff Phone";
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 27);
            txtName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(178, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(273, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(178, 269);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(273, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(178, 318);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(273, 27);
            txtAddress.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 321);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 13;
            label7.Text = "Staff Address";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 10;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(128, 128, 255);
            label8.FlatStyle = FlatStyle.System;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(348, 7);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 2;
            label8.Text = "Staff Creation";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(495, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(647, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(178, 223);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(273, 27);
            txtDob.TabIndex = 17;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDob);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Name = "AddStaff";
            Text = "AddStaff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label txtPass;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label label7;
        private Panel panel1;
        private Label label3;
        private Label label8;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker txtDob;
    }
}