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
    public partial class frm_RegistraionForm : Form
    {
        public frm_RegistraionForm()
        {
            InitializeComponent();
        }

        private void RegistraionForm_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        
        private void chkUsername_CheckedChanged(object sender, EventArgs e)
        {
            if(chkUsername.Checked==true)
            {
                txtUsrname.Text = txt_emailid.Text;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            frm_adminLogin admin = new frm_adminLogin();
            admin.Show();
            this.Dispose();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            registerData();
            frm_adminLogin admin = new frm_adminLogin();
            admin.Show();
            this.Dispose();
            clearControl();
            txt_name.Focus();
        }

        private void clearControl()
        {
            txt_name.Clear();
            txt_mobileno .Clear();
            txt_emailid .Clear();
            txtUsrname .Clear();
            txt_password .Clear();
            txtconfirmpassword .Clear();
            
        }

        private void registerData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_Registration values('"+ txt_name.Text.Trim()+"','"+txt_mobileno.Text.Trim()+"','"+txt_emailid.Text.Trim()+"','"+txtUsrname.Text.Trim()+"','"+txt_password.Text.Trim()+"')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registeed Successed");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password .PasswordChar = '\0';
            txt_password.UseSystemPasswordChar = false;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '*';
            txt_password.UseSystemPasswordChar = true ;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            txtconfirmpassword.PasswordChar = '\0';
            txtconfirmpassword.UseSystemPasswordChar = false;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            txtconfirmpassword.PasswordChar = '*';
            txtconfirmpassword.UseSystemPasswordChar = true ;
        }

        private void txt_emailid_Leave(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

			if (txt_emailid .Text.Length > 0 && txt_emailid.Text.Trim().Length != 0)
			{
				if (!rEmail.IsMatch(txt_emailid.Text.Trim()))
				{
					MessageBox.Show("Invalid Email-id","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_emailid.SelectAll();
					//e.Cancel = true;
				}
			}
        }

        private void txt_mobileno_Leave(object sender, EventArgs e)
        {
            if (txt_mobileno .Text.Length > 10)
            {
                MessageBox.Show("Invalid Mobile No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mobileno.Clear();
            }
        }

        private void txtconfirmpassword_Leave(object sender, EventArgs e)
        {
            if (txt_password .Text == txtconfirmpassword .Text)
            {
                registerData();

            }
            else
            {
                MessageBox.Show("Did not match your Password to Confirm Password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconfirmpassword .Clear();
            }
        }
    }
}
