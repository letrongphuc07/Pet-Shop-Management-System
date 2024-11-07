using System;
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
    public partial class Dashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        string title = "Pet Shop Management System";
        public Dashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
        }

        #region method
        public int extracData(string str)
        {
            int data = 0;
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT ISNULL(SUM(pqty),0) AS qty FROM tbProduct WHERE pcategory='" + str + "'", cn);
                data = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
            }
            catch (Exception ex) 
            {
                cn.Close();
                MessageBox.Show(ex.Message,title);
            }
            return data;
        }
        #endregion method

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblDog.Text = extracData("Dog").ToString();
            lblCat.Text = extracData("Cat").ToString();
            lblBird.Text = extracData("Bird").ToString();
            lblFish.Text = extracData("Fish").ToString();
        }
    }
}
