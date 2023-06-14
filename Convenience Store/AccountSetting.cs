using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Convenience_Store
{

    public partial class AccountSetting : Form
    {
        private readonly Account _account;
        private RepoAccount _Account;




        public AccountSetting(List<Account> accounts)
        {
            InitializeComponent();
            _Account = new RepoAccount();
            _account = accounts.FirstOrDefault(); // Get the first account in the list
            txtId.Text = _account.AccId.ToString();
            txtName2.Text = _account.AccName;
            txtRole.Text = _account.AccRole.ToString();
            txtId1.Text = _account.AccId.ToString();
            txtRole1.Text = _account.AccRole.ToString();
            var accRoles = _Account.GetAll().Select(a => a.AccRole).Distinct(); // Get AccRole values from the accounts list

            /*cbRole.DataSource = accRoles.ToList(); // Bind the accRoles list to the ComboBox
            cbRole.Refresh(); // Refresh the ComboBox*/

            // Populate the text boxes with the account data
            txtName1.Text = _account.AccName;
            txtPassword.Text = _account.AccPass;
            dtpDOB.Value = (DateTime)_account.AccDob;
            txtPhone.Text = _account.AccPhone;
            //cbRole.Text = _account.AccRole.ToString(); // Set the ComboBox value to the account's AccRole
            txtAddress.Text = _account.AccAddress;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Find the account with matching ID
            var currAccount = _Account.GetAll().FirstOrDefault(a => a.AccId == _account.AccId);
            if (string.IsNullOrEmpty(txtName1.Text))
            {
                MessageBox.Show("Please enter a valid name", "Error");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 3)
            {
                MessageBox.Show("Please enter a password with at least 3 characters", "Error");
                return;
            }
            if (dtpDOB.Value == null || dtpDOB.Value > DateTime.Today)
            {
                MessageBox.Show("Please enter a valid date of birth", "Error");
                return;
            }
            if (!Regex.IsMatch(txtPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number", "Error");
                return;
            }

            if (currAccount != null)
            {
                // Update the account with the new values from the text boxes and ComboBox
                currAccount.AccName = txtName1.Text;
                currAccount.AccPass = txtPassword.Text;
                currAccount.AccDob = dtpDOB.Value;
                currAccount.AccPhone = txtPhone.Text;
                //currAccount.AccRole = (int)cbRole.SelectedItem;
                currAccount.AccAddress = txtAddress.Text;

                // Save the updated account to the database
                _Account.Update(currAccount);

                // Show a message box indicating that the account was updated
                MessageBox.Show("Account updated successfully", "Success");
            }
            else
            {
                // Account with matching ID not found, display an error message
                MessageBox.Show("Account not found", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
