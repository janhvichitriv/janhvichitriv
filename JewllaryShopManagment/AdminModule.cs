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
    public partial class frm_AdminModule : Form
    {
        private int childFormNumber = 0;

        public frm_AdminModule()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void rateModuleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_RateModule rate = new frm_RateModule();
            rate.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_customermodule customer = new frm_customermodule();
            customer.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ordermodule order = new frm_ordermodule();
            order.Show();
        }

        private void purchasingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_purchasingRmodule purchase = new frm_purchasingRmodule();
            purchase.Show();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_salesReport sale = new frm_salesReport();
            sale.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_billmodule bill = new frm_billmodule();
            bill.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Faultmodule fault = new frm_Faultmodule();
            fault.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_loan loan = new frm_loan();
            loan.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frm_rdmodule rd = new frm_rdmodule();
            rd.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminLogin login = new frm_adminLogin();
            login.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=jwellaryshop;Integrated Security=True");
        private void frm_AdminModule_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_adminLogin admin = new frm_adminLogin();
            admin.Show();
            this.Dispose();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frm_categoryregistration category = new frm_categoryregistration();
            category.Show();
            this.Dispose();
        }
    }
}