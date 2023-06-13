namespace Convenience_Store
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            button1 = new Button();
            cbPassword = new CheckBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(481, 120);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Paint += btnLogin_Paint;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.ActiveCaptionText;
            txtPassword.Location = new Point(140, 70);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(427, 23);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(140, 15);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(427, 23);
            txtUsername.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 74);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 6;
            label1.Text = "Username\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.ForeColor = SystemColors.MenuText;
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 115);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(-9, 105);
            label6.Name = "label6";
            label6.Size = new Size(927, 10);
            label6.TabIndex = 17;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(111, -17);
            label3.Name = "label3";
            label3.Size = new Size(703, 106);
            label3.TabIndex = 0;
            label3.Text = "Convenience Store";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(2, 474);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 124);
            panel2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(792, 89);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 1;
            label4.Text = "Login Page";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(10, 85);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(588, 72);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(129, 21);
            cbPassword.TabIndex = 14;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbPassword);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(83, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 163);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(83, 154);
            panel4.Name = "panel4";
            panel4.Size = new Size(764, 105);
            panel4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(319, 32);
            label5.Name = "label5";
            label5.Size = new Size(157, 38);
            label5.TabIndex = 0;
            label5.Text = "Login Form";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(-4, 461);
            label7.Name = "label7";
            label7.Size = new Size(927, 10);
            label7.TabIndex = 18;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label7);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Button button1;
        private CheckBox cbPassword;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label6;
        private Label label7;
    }
}