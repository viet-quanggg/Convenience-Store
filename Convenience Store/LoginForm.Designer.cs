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
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            btnExit = new Button();
            cbPassword = new CheckBox();
            panel3 = new Panel();
            btnclear = new Button();
            panel4 = new Panel();
            label5 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            btnLogin.Location = new Point(722, 180);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 46);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Paint += btnLogin_Paint;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.ActiveCaptionText;
            txtPassword.Location = new Point(210, 105);
            txtPassword.Margin = new Padding(4, 6, 4, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(638, 29);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(210, 22);
            txtUsername.Margin = new Padding(4, 6, 4, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(638, 29);
            txtUsername.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 6;
            label1.Text = "Username\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.MenuText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 172);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(192, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1021, 149);
            label3.TabIndex = 0;
            label3.Text = "Convenience Store";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(0, 714);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1371, 186);
            panel2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1188, 134);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 38);
            label4.TabIndex = 1;
            label4.Text = "Login Page";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(15, 128);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 44);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(882, 108);
            cbPassword.Margin = new Padding(4);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(179, 29);
            cbPassword.TabIndex = 14;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnclear);
            panel3.Controls.Add(cbPassword);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(124, 386);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1146, 244);
            panel3.TabIndex = 15;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(62, 180);
            btnclear.Margin = new Padding(4);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(141, 44);
            btnclear.TabIndex = 15;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(124, 231);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1146, 158);
            panel4.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(425, 51);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(271, 65);
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 6, 4, 6);
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
        private Button btnExit;
        private CheckBox cbPassword;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnclear;
    }
}