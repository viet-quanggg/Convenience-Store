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
        public string Username { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            var check = RepoAccount.GetAll().Where(a => a.AccName.Equals(Username)).Select(a => a.AccId).FirstOrDefault();
            if (check != 1)
            {
                btnCustomer.Visible = false;
            }
            else
            {
                btnCustomer.Visible = true;
            }
        }
    }
}
