using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Convenience_Store
{

    public partial class AccountSetting : Form
    {
        private readonly Account _account;

        public AccountSetting(List<Account> accounts)
        {
            InitializeComponent();

            _account = accounts.FirstOrDefault(); // Get the first account in the list
            txtId.Text = _account.AccId.ToString();
            txtName2.Text = _account.AccName;
            txtRole.Text = _account.AccRole.ToString();
        }
    }

}
