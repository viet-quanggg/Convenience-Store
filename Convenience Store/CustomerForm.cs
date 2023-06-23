using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store
{
    public partial class CustomerForm : Form
    {
        private readonly Account _account;
        RepoAccount repoAccount = new RepoAccount();
        RepoCustomer customer = new RepoCustomer();
        public CustomerForm(List<Account> accounts)
        {
            InitializeComponent();
            _account = accounts.FirstOrDefault();
            if (_account != null)
            {
                txtId.Text = _account.AccId.ToString();
                txtName.Text = _account.AccName;
                txtRole.Text = _account.AccRole.ToString();

            }
            List<Customer> customers = customer.GetAll();
            dgvCustomer.DataSource = new BindingSource() { DataSource = customers };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            var link = repoAccount.GetAll().Where(a => a.AccId.Equals(_account.AccId));
            HomePage homePage = new HomePage(link.ToList());
            homePage.Show();
            this.Close();
        }
    }
}
