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
    public partial class frm_adminLogin : Form
    {
        public frm_adminLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Registration where Username='"+txt_Username.Text +"' and Password='"+txt_Password.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                frm_AdminModule mdi = new frm_AdminModule();
                mdi.Show();
            }
            else
            {
                MessageBox.Show("Invalid Registration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Username.Clear();
                txt_Password.Clear();
                txt_Username.Focus();
            }
        }
        private void btn_newRegistration_Click(object sender, EventArgs e)
        {
            frm_RegistraionForm registrationForm = new frm_RegistraionForm();
            registrationForm.Show();
        }
        private void frm_adminLogin_Load(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //        txt_Password.PasswordChar = default(char);
        //}

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Password.PasswordChar = '\0';
            txt_Password.UseSystemPasswordChar = false;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Password.PasswordChar = '*';
            txt_Password.UseSystemPasswordChar = true;
        }
    }
}
