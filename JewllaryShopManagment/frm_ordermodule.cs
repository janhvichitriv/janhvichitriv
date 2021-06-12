﻿using System;
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
    public partial class frm_ordermodule : Form
    {
        public frm_ordermodule()
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

        private void frm_ordermodule_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_order", con);
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
            txt_orderid.Focus();
        }

        private void resetControl()
        {
            txt_orderid.Clear();
            txt_custid.Clear();
            txt_custname.Clear();
            txt_address.Clear();
            txt_phoneno.Clear();
            txt_itemid.Clear();
            
        }

        private void insertData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_order values('"+txt_orderid.Text.Trim()+"','"+txt_custid.Text.Trim()+"','"+txt_custname.Text.Trim()+"','"+txt_address.Text.Trim()+"','"+txt_phoneno.Text.Trim()+"','"+txt_itemid.Text.Trim()+"','"+lbox_itemmodel.Text.ToString()+"','"+dateTimePicker1.Text+"','"+dateTimePicker2.Text+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save Successed");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            txt_orderid.Text  = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_custid.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_custname.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_address.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_phoneno.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_itemid.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            lbox_itemmodel.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            resetControl();
        }

        private void lbox_itemmodel_Leave(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Item_id from tbl_categoryRegistration where Item_name='" + lbox_itemmodel.SelectedItem.ToString() + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            txt_itemid.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        
    }
}
