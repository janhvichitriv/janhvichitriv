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
    public partial class frm_salesReport : Form
    {
        public frm_salesReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        private void frm_salesReport_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_sales", con);
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
            txt_Grosssales.Focus();
        }

        private void resetControl()
        {
            txt_Grosssales.Clear();
            txt_totalsales.Clear();
            txt_averagesalesvalue.Clear();
            txt_overallgrossvalue.Clear();
            txt_percentofannualsale.Clear();
        }

        private void insertData()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_sales values('" + txt_Grosssales.Text.Trim() + "','"+txt_totalsales.Text.Trim()+"','"+txt_averagesalesvalue.Text.Trim()+"','"+txt_overallgrossvalue.Text.Trim()+"','"+txt_percentofannualsale.Text.Trim()+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save Successed");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            txt_Grosssales.Text  = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_totalsales.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_averagesalesvalue.Text  = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_overallgrossvalue.Text  = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_percentofannualsale.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();

        }
    }
}
