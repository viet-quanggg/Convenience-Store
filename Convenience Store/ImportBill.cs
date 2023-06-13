using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Repository;

namespace Convenience_Store
{
    public partial class ImportBill : Form
    {
        RepoImportBill repoBill;
        public ImportBill()
        {
            repoBill = new RepoImportBill();
            var list = repoBill.GetAll();
            dgvImportBill.DataSource = new BindingSource() { DataSource = list };
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Form billPopup = new ImportPopup();
            billPopup.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form billPopup = new ImportPopup();
            billPopup.ShowDialog();
        }
    }
}
