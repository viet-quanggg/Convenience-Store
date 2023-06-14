using Service.Repository;
using System.Drawing.Drawing2D;
using Service.Repository;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.ApplicationServices;
using Service.Models;

namespace Convenience_Store
{
    public partial class LoginForm : Form
    {
         RepoAccount RepoAccount = new RepoAccount();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtUsername.Text;
            string password = txtPassword.Text;
            var check = RepoAccount.GetAll().FirstOrDefault(a => a.AccName.Equals(account) && a.AccPass.Equals(password));
            var link = RepoAccount.GetAll().Where(a => a.AccName.Equals(account));

            if (check != null)
            {
                MessageBox.Show("đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
                this.Hide();
               
                //return home page
                //HomePage.Username = username;
                Form form = new HomePage(link.ToList());
                
                form.ShowDialog();
 

            }
            else
            {
                MessageBox.Show("đăng nhập thất bại", "thông báo", MessageBoxButtons.OK);
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
    }
}
