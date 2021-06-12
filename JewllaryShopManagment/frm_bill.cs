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
    public partial class frm_billmodule : Form
    {
        public frm_billmodule()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            frm_AdminModule admin = new frm_AdminModule();
            admin.Show();
            this.Dispose();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void frm_billmodule_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        private void loadData()
        {
            dateTimePicker1.Value= DateTime.Now;
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_bill", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            frm_AdminModule admin = new frm_AdminModule();
            admin.Show();
            this.Dispose();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            insertData();
            loadData();
            resetControl();
            dateTimePicker1.Focus();
        }

        private void resetControl()
        {
            txt_billnumber.Clear();
            txt_custid.Clear();
            txt_custname.Clear();
            txt_purchasingamount.Clear();
            txt_discount.Clear();
            txt_totalamount.Clear();
        }

        private void insertData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_bill values('" +dateTimePicker1+ "','" +txt_billnumber.Text.Trim() + "','" +txt_custid.Text.Trim()+ "','" + txt_custname.Text.Trim() + "','" + txt_purchasingamount.Text.Trim() + "','" + lbox_itemmodel.Text.ToString() + "','" + txt_discount.Text.Trim() + "','"+txt_totalamount.Text.ToString()+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save Successed");
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            resetControl();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_billnumber.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_custid.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_custname.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_purchasingamount.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            lbox_itemmodel.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_discount.Text= dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt_totalamount.Text= dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbox_itemmodel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbox_itemmodel_Leave(object sender, EventArgs e)
        {
            //SqlDataAdapter sda = new SqlDataAdapter("select Item_id from tbl_categoryRegistration where Item_name='" + lbox_itemmodel.SelectedItem.ToString() + "'", con);
            //DataSet ds = new DataSet();
            //sda.Fill(ds);
            //txt_itemid.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            float rate = Convert.ToSingle(txt_purchasingamount .Text);
            float discount = Convert.ToSingle(txt_discount.Text);
            float amount = rate - (rate * discount / 100);
            txt_totalamount.Text = Convert.ToDecimal(amount).ToString();
        }
    }
}
