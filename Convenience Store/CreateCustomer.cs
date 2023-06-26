﻿using Microsoft.EntityFrameworkCore;
using Service.Models;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            InitializeComponent();
            this.dgvCustomer = dgvCustomer;
            this.account = account;
            this.Text = string.Empty;
            this.ControlBox = false;

            // Set customer ID to the max ID in the DataGridView + 1
            /*int maxId = dgvCustomer.Rows.Cast<DataGridViewRow>()
                .Select(row => (int)row.Cells["CusId"].Value)
                .Max();
            txtCusId.Text = (maxId + 1).ToString();*/
        }

        private void refreshData()
        {
            var listAllStaff = customer.GetAll()
           .Select(x => new
           {
               /*x.CusId,*/
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
                Customer cus = new Customer();
                /*using (var context = new ConvenienceStoreContext())
                {

                    cus.CusName = txtCusName.Text;
                    cus.CusGender = int.Parse(txtcusGender.Text);
                    cus.CusDob = dtpDOB.Value;
                    cus.CusPhone = txtCusPhone.Text;
                    // Add the new customer to the database
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Customer] ON;");
                    context.Customers.Add(cus);
                    context.SaveChanges();
                    *//*                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Customer] OFF;");*//*
                }*/

                cus.CusName = txtCusName.Text;
                cus.CusGender = int.Parse(txtcusGender.Text);
                cus.CusDob = dtpDOB.Value;
                cus.CusPhone = txtCusPhone.Text;
                customer.Create(cus);



                int newCustomerId = cus.CusId;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
