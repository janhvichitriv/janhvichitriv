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
    public partial class frm_customermodule : Form
    {
        public frm_customermodule()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            frm_AdminModule admin = new frm_AdminModule();
            //admin.Show();
            this.Close();
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

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_customermodule_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_customer", con);
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
            saveData();
            loadData();
            resetData();
            txt_Custid.Focus();
        }

        private void resetData()
        {
            txt_Custid.Clear();
            txt_custname.Clear();
            txt_address.Clear();
            txt_city.Clear();
            txt_phoneno.Clear();
            txt_amount.Clear();
            lbox_itemmodel.ClearSelected();
        }

        private void saveData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_customer values('" + txt_Custid.Text.Trim() + "','" + txt_custname.Text.Trim() + "','" + txt_address.Text.Trim() + "','" + txt_city.Text.Trim() + "','" + txt_phoneno.Text.Trim() + "','" + lbox_itemmodel.Text.ToString() + "','" + txt_amount.Text.Trim() + "','"+fname+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save Successed");
        }
        string fname = "";
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|Image File|*.png|Image File|*.jpg|WordPadFile|*.jpeg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = ".";
            openFileDialog1.Title = "Browse your photo";
            openFileDialog1.FileName = "FileName";
            openFileDialog1.ShowDialog();

            fname = openFileDialog1.FileName;
            pictureBox2.Image = Image.FromFile(fname);
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            resetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            txt_Custid.Text  = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_custname.Text= dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_address.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_city.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_phoneno.Text  = dataGridView1.Rows[i].Cells[4].Value.ToString();
            lbox_itemmodel.Text  = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_amount.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
