﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop_Management_System
{
    public partial class CustomerForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr = null!;
        string title = "Pet Shop Management System";
        public CustomerForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            LoadCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerModule module = new CustomerModule(this);
            module.ShowDialog();
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModule module = new CustomerModule(this);
                module.lblcid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();

                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer record", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("DELETE FROM tbCustomer WHERE id LIKE'" + dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    MessageBox.Show("Customer data has been successfully removed", title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

            LoadCustomer();
        }

        #region method
        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT id,name,phone FROM tbCustomer WHERE CONCAT(name,address,phone) LIKE '%" + txtSearch.Text + "'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        #endregion method


    }
}
