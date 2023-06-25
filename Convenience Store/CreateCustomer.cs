using Microsoft.EntityFrameworkCore;
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
using System.Xml.Linq;

namespace Convenience_Store
{
    public partial class CreateCustomer : Form
    {
        private DataGridView dgvCustomer;
        private Account account;
        RepoCustomer customer = new RepoCustomer();

        public CreateCustomer(DataGridView dgvCustomer, Account account)
        {
            this.dgvCustomer = dgvCustomer;
            this.account = account;
            InitializeComponent();
            this.dgvCustomer = dgvCustomer;
            this.account = account;

            // Set customer ID to the max ID in the DataGridView + 1
            int maxId = dgvCustomer.Rows.Cast<DataGridViewRow>()
                .Select(row => (int)row.Cells["CusId"].Value)
                .Max();
            txtCusId.Text = (maxId + 1).ToString();
        }

        private void refreshData()
        {
            var listAllStaff = customer.GetAll()
           .Select(x => new
           {
               x.CusId,
               x.CusName,
               x.CusGender,
               x.CusDob,
               x.CusPhone
           })
           .ToList();

            dgvCustomer.DataSource = new BindingSource() { DataSource = listAllStaff };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Customer object with the entered data
                string cusName = txtCusName.Text;
                int cusGender = int.Parse(txtcusGender.Text);
                DateTime cusDob = dtpDOB.Value;
                string cusPhone = txtCusPhone.Text;
                
                    // No entity with the same key value is being tracked, so create a new entity and add it to the context
                    int maxCusId = dgvCustomer.Rows.Cast<DataGridViewRow>()
                        .Select(row => (int)row.Cells["CusId"].Value)
                        .Max();
                    int newCusId = maxCusId + 1;

                    Customer newCustomer = new Customer()
                    {
                        CusId = newCusId,
                        CusName = cusName,
                        CusGender = cusGender,
                        CusDob = cusDob,
                        CusPhone = cusPhone
                    };

                    // Add the new customer to the database
                    customer.Create(newCustomer);
                

                // refresh the data grid view with updated data
                refreshData();

                // close the pop-up form
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"An error occurred while updating the entries: {ex.InnerException?.Message}");
            }
        }


    }
}
