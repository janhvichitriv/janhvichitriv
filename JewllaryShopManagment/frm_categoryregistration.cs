using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JewllaryShopManagment
{
    public partial class frm_categoryregistration : Form
    {
        public frm_categoryregistration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
            clearData();
        }

        private void AddData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_categoryRegistration values('" + txt_itemname.Text.Trim() + "','" + txt_itemid.Text.Trim() + "','"+txt_itemno.Text.Trim()+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("saved successfully");
        }

        private void clearData()
        {
            txt_itemname.Clear();
            txt_itemid.Clear();
            txt_itemno.Clear();
        }
    }
}
