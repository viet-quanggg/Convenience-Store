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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Convenience_Store
{
    public partial class HomePage : Form
    {
        RepoAccount RepoAccount = new RepoAccount();

        private List<Account> _accounts;
        public List<Account> Accounts
        {
            get { return _accounts; }
            set { _accounts = value; }
        }

        public HomePage(List<Account> accounts)
        {
            InitializeComponent();
            Accounts = accounts;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //ẩn nút cho từng role
            var check = Accounts.FirstOrDefault(a => a.AccRole != 0); ;
            if (check != null)
            {
                btnCustomer.Visible = false;
            }
            else
            {
                btnCustomer.Visible = true;
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            /*Form order = new (Accounts);
            order.ShowDialog();*/
        }

        private void btnMerchandise_Click(object sender, EventArgs e)
        {
            /*Form merchandise = new (Accounts);
            merchandise.ShowDialog();*/
        }

        private void btnExportBill_Click(object sender, EventArgs e)
        {
            /*Form exportbill = new (Accounts);
            exportbill.ShowDialog();*/
        }

        private void btnImportBill_Click(object sender, EventArgs e)
        {
            /*Form importbill = new (Accounts);
            importbill.ShowDialog();*/
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            /*Form customer = new (Accounts);
            customer.ShowDialog();*/
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form setting = new AccountSetting(Accounts);
            setting.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Close the current form
                this.Close();

                // Create a new instance of the LoginForm and display it
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                return;
            }
        }
    }
}
