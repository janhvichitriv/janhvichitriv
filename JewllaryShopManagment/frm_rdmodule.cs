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
    public partial class frm_rdmodule : Form
    {
        public frm_rdmodule()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
       

        private void frm_rdmodule_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_rd", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            frm_AdminModule mdi = new frm_AdminModule();
            mdi.Show();
            this.Dispose();
        }

        
        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            frm_AdminModule admin = new frm_AdminModule();
            admin.Show();
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            insertData();
            loadData();
            resetControl();
            txt_custid.Focus();
        }

        private void resetControl()
        {
            txt_custid.Clear();
            txt_custname.Clear();
            txt_rdamount.Clear();
            txt_address.Clear();
            txt_phoneno.Clear();
            lbox_rdtype.ClearSelected();
            lbox_rdmaturity.ClearSelected();
            txt_adharcardno.Clear();
            txt_finalamount.Clear();
        }

        private void insertData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_rd values('" +txt_custid.Text.Trim()+ "','"+txt_custname.Text.Trim()+"','"+txt_rdamount.Text.Trim()+"','"+txt_address.Text.Trim()+"','"+txt_phoneno.Text.Trim()+"','"+lbox_rdtype.Text.ToString()+"','"+lbox_rdmaturity.Text.ToString()+"','"+txt_adharcardno.Text.Trim()+"','"+date_dob +"','"+txt_finalamount.Text.Trim()+"')";
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
            txt_custid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_custname.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_rdamount.Text  = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_address.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_phoneno.Text  = dataGridView1.Rows[i].Cells[4].Value.ToString();
            lbox_rdtype.Text  = dataGridView1.Rows[i].Cells[5].Value.ToString();
            lbox_rdmaturity.Text  = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt_adharcardno.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            date_dob.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txt_finalamount.Text= dataGridView1.Rows[i].Cells[9].Value.ToString();
        }
    }
}
