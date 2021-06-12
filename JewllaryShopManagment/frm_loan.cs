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
    public partial class frm_loan : Form
    {
        public frm_loan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        private void frm_loan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_loan",con);
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            insertData();
            loadData();
            resetControl();
            txt_Custid.Focus();
        }

        private void insertData()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_loan values('" +txt_Custid.Text.Trim()+ "','"+txt_custname.Text.Trim()+"','"+txt_address.Text.Trim()+"','"+txt_city.Text.Trim()+"','"+txt_phoneno.Text.Trim()+"','"+txt_loanammount.Text.Trim()+"','"+txt_interestrate.Text.Trim()+"','"+dtp_purchasingdate +"','"+dtp_returndate +"','"+txt_finalamount.Text.Trim()+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save Successed");
        }

        private void resetControl()
        {
            txt_Custid.Clear();
            txt_custname.Clear();
            txt_address.Clear();
            txt_city.Clear();
            txt_phoneno.Clear();
            txt_loanammount.Clear();
            txt_interestrate.Clear();
            txt_finalamount.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            txt_Custid.Text  = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_custname.Text  = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_address.Text  = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_city.Text  = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_phoneno.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_loanammount.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_interestrate.Text= dataGridView1.Rows[i].Cells[6].Value.ToString();
            dtp_purchasingdate.Text= dataGridView1.Rows[i].Cells[7].Value.ToString();
            dtp_returndate.Text= dataGridView1.Rows[i].Cells[8].Value.ToString();
        }

        private void txt_interestrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_interestrate_Leave(object sender, EventArgs e)
        {
            float loan = Convert.ToSingle(txt_loanammount.Text);
            float interest = Convert.ToSingle(txt_interestrate.Text);
            float amount = loan+(loan * interest / 100);
            txt_finalamount.Text = Convert.ToDecimal(amount).ToString();

        }
    }
}
