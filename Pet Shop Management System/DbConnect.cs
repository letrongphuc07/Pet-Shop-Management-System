using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pet_Shop_Management_System
{
    internal class DbConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;
        public DbConnect()
        {
            con= @"Data Source=DESKTOP-37BI0EK\SQLEXPRESS;Initial Catalog=dbPetShop;Integrated Security=True;Connect Timeout=30";
        }   
        public string connection()
        {
            return con;
        }
        public void executeQuery(string sql)
        {
            try
            {
                cn.ConnectionString = connection();
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cm.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
