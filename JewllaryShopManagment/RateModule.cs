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
    public partial class frm_RateModule : Form
    {
        public frm_RateModule()
        {
            InitializeComponent();
        }

       

        private void frm_RateModule_Load(object sender, EventArgs e)
        {
            loadData();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void loadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_rate", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            frm_AdminModule admin = new frm_AdminModule();
            admin.Show();
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            txt_itemno.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_itemid.Text  = dataGridView1.Rows[i].Cells[1].Value.ToString();
            lbl_itemModule.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_itemrate.Text  = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_discount.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_amount.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData();
            loadData();
            ResetControl();
            txt_itemno.Focus();
        }

        private void SaveData()
        {
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_rate values('"+txt_itemno.Text.Trim()+"','"+txt_itemid.Text.Trim()+"','"+lbox_itemmodel.Text.ToString()+"','"+txt_itemrate.Text.Trim()+"','"+txt_discount.Text.Trim()+"','"+txt_amount.Text.Trim()+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save Successed");
        }

        private void ResetControl()
        {
            txt_itemno.Clear();
            txt_itemid.Clear();
            txt_amount.Clear();
            txt_discount.Clear();
            txt_itemrate.Clear();
            lbox_itemmodel.ClearSelected();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void lbox_itemmodel_leave(object sender, EventArgs e)
        {
            modelSelection();
        }

        private void modelSelection()
        {
            //string item = " ";
            //SqlDataAdapter sda = new SqlDataAdapter("select id from tbl_rate where Item_model='"+lbox_itemmodel.Text+"'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

        }

        private void txt_discount_Leave_1(object sender, EventArgs e)
        {
            float rate = Convert.ToSingle(txt_itemrate.Text);
            float discount = Convert.ToSingle(txt_discount.Text);
            float amount = rate-(rate * discount / 100);
            txt_amount.Text =Convert.ToDecimal(amount).ToString();

            //string num1= ((Convert.ToDecimal(txt_itemrate.Text)) / (Convert.ToDecimal(txt_discount.Text))).ToString();
            //txt_amount.Text = num1.ToString() * Convert.ToInt32(num);
        }

                private void callitemid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Item_id from tbl_categoryRegistration where Item_name='" + lbox_itemmodel.SelectedItem.ToString() + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            txt_itemid.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void callitemno()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Item_no from tbl_categoryRegistration where Item_name='" + lbox_itemmodel.SelectedItem.ToString() + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            txt_itemno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void lbox_itemmodel_Leave_1(object sender, EventArgs e)
        {
            callitemno();
            callitemid();
        }
    }
}
