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
using Service.Repository;
using Service.Models;
using MechandiseList;

namespace Convenience_Store
{
    public partial class MerchandiseList : Form
    {
        private Merchandise merchandise = new Merchandise();

        private RepoMerchandise repoMerchandise = new RepoMerchandise();

        List<MerchandiseList> list = new List<MerchandiseList>();
        public static DataGridViewRow SelectedRow { get; set; }
        int index;
        public MerchandiseList()
        {
            InitializeComponent();

            dgvMerchandise.DataSource = new BindingSource() { DataSource = repoMerchandise.GetAll().ToList() };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        /*private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }*/

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Form order = new Order();
            order.ShowDialog();
            this.Close();
        }
    }
}
