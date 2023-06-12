using static System.Net.Mime.MediaTypeNames;

namespace Convenience_Store
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Equals("admin") && password.Equals("1234"))
            {
                MessageBox.Show("đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
                this.Hide();

                //return home page
                //Form form = new test();
                //form.ShowDialog();

            }
            else
            {
                MessageBox.Show("đăng nhập thất bại", "thông báo", MessageBoxButtons.OK);
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
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
    }
}
