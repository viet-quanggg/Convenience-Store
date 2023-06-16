using Service.Repository;
using System.Drawing.Drawing2D;
using Service.Repository;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.ApplicationServices;
using Service.Models;
using System.Text.RegularExpressions;

namespace Convenience_Store
{
    public partial class LoginForm : Form
    {
        RepoAccount RepoAccount = new RepoAccount();
        public LoginForm()
        {
            InitializeComponent();

        }

        public Boolean ValidateString(string s)
        {
            return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);

        }
        public string formatString(string s)
        {
            return Regex.Replace(s, @"\s+", " ").Trim();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.ToLower();
            string password = txtPassword.Text;
            
            

            if (ValidateString(txtUsername.Text) || Regex.IsMatch(formatString(txtUsername.Text), @"^[^a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a valid name", "Error");
                return;
            }
            if (ValidateString(txtPassword.Text) || txtPassword.Text.Length < 3)
            {
                MessageBox.Show("Please enter a password with at least 3 characters", "Error");
                return;
            }
            var check = RepoAccount.GetAll().Where(a => a.AccName.ToLower().Equals(user) && a.AccPass.Equals(password));
            if (check.Count() == 1)
            {
                var link = RepoAccount.GetAll().Where(a => a.AccName.ToLower().Equals(user));
                if (MessageBox.Show("Login success", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Hide();
                    // Truyền danh sách tài khoản cho form HomePage
                    Form homePage = new HomePage(link.ToList());
                    homePage.ShowDialog();
                }

                else
                {
                    return;
                }


            }
            else
            {
                MessageBox.Show("Login fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void cbPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
