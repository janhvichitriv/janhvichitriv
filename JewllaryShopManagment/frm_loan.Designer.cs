
namespace JewllaryShopManagment
{
    partial class frm_loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_interestrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phoneno = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_Custid = new System.Windows.Forms.TextBox();
            this.txt_custname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_itemdiscout = new System.Windows.Forms.Label();
            this.lbl_itemrate = new System.Windows.Forms.Label();
            this.lbl_itemModule = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.lbl_itemno = new System.Windows.Forms.Label();
            this.txt_loanammount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_purchasingdate = new System.Windows.Forms.DateTimePicker();
            this.dtp_returndate = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_finalamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(507, 97);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(160, 34);
            this.txt_address.TabIndex = 3;
            // 
            // txt_interestrate
            // 
            this.txt_interestrate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_interestrate.Location = new System.Drawing.Point(507, 269);
            this.txt_interestrate.Name = "txt_interestrate";
            this.txt_interestrate.Size = new System.Drawing.Size(160, 34);
            this.txt_interestrate.TabIndex = 7;
            this.txt_interestrate.TextChanged += new System.EventHandler(this.txt_interestrate_TextChanged);
            this.txt_interestrate.Leave += new System.EventHandler(this.txt_interestrate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(303, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Interest Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "Loan Module";
            // 
            // txt_phoneno
            // 
            this.txt_phoneno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneno.Location = new System.Drawing.Point(507, 183);
            this.txt_phoneno.Name = "txt_phoneno";
            this.txt_phoneno.Size = new System.Drawing.Size(160, 34);
            this.txt_phoneno.TabIndex = 5;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(507, 140);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(160, 34);
            this.txt_city.TabIndex = 4;
            // 
            // txt_Custid
            // 
            this.txt_Custid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Custid.Location = new System.Drawing.Point(507, 11);
            this.txt_Custid.Name = "txt_Custid";
            this.txt_Custid.Size = new System.Drawing.Size(160, 34);
            this.txt_Custid.TabIndex = 1;
            // 
            // txt_custname
            // 
            this.txt_custname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_custname.Location = new System.Drawing.Point(507, 54);
            this.txt_custname.Name = "txt_custname";
            this.txt_custname.Size = new System.Drawing.Size(160, 34);
            this.txt_custname.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::JewllaryShopManagment.Properties.Resources._61;
            this.pictureBox1.Location = new System.Drawing.Point(11, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_amount.Location = new System.Drawing.Point(301, 233);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(169, 27);
            this.lbl_amount.TabIndex = 48;
            this.lbl_amount.Text = "Loan Ammount:";
            // 
            // lbl_itemdiscout
            // 
            this.lbl_itemdiscout.AutoSize = true;
            this.lbl_itemdiscout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemdiscout.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemdiscout.Location = new System.Drawing.Point(303, 190);
            this.lbl_itemdiscout.Name = "lbl_itemdiscout";
            this.lbl_itemdiscout.Size = new System.Drawing.Size(114, 27);
            this.lbl_itemdiscout.TabIndex = 47;
            this.lbl_itemdiscout.Text = "Phone No:";
            // 
            // lbl_itemrate
            // 
            this.lbl_itemrate.AutoSize = true;
            this.lbl_itemrate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemrate.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemrate.Location = new System.Drawing.Point(303, 147);
            this.lbl_itemrate.Name = "lbl_itemrate";
            this.lbl_itemrate.Size = new System.Drawing.Size(59, 27);
            this.lbl_itemrate.TabIndex = 46;
            this.lbl_itemrate.Text = "City:";
            // 
            // lbl_itemModule
            // 
            this.lbl_itemModule.AutoSize = true;
            this.lbl_itemModule.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemModule.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemModule.Location = new System.Drawing.Point(303, 104);
            this.lbl_itemModule.Name = "lbl_itemModule";
            this.lbl_itemModule.Size = new System.Drawing.Size(96, 27);
            this.lbl_itemModule.TabIndex = 45;
            this.lbl_itemModule.Text = "Address:";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemid.Location = new System.Drawing.Point(303, 61);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(174, 27);
            this.lbl_itemid.TabIndex = 44;
            this.lbl_itemid.Text = "Customer Name:";
            // 
            // lbl_itemno
            // 
            this.lbl_itemno.AutoSize = true;
            this.lbl_itemno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemno.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemno.Location = new System.Drawing.Point(303, 18);
            this.lbl_itemno.Name = "lbl_itemno";
            this.lbl_itemno.Size = new System.Drawing.Size(137, 27);
            this.lbl_itemno.TabIndex = 43;
            this.lbl_itemno.Text = "Customer Id:";
            // 
            // txt_loanammount
            // 
            this.txt_loanammount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loanammount.Location = new System.Drawing.Point(507, 226);
            this.txt_loanammount.Name = "txt_loanammount";
            this.txt_loanammount.Size = new System.Drawing.Size(160, 34);
            this.txt_loanammount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(303, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 27);
            this.label3.TabIndex = 53;
            this.label3.Text = "L-Purchasing Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(303, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 27);
            this.label4.TabIndex = 54;
            this.label4.Text = "L-Return Date:";
            // 
            // dtp_purchasingdate
            // 
            this.dtp_purchasingdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_purchasingdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_purchasingdate.Location = new System.Drawing.Point(508, 312);
            this.dtp_purchasingdate.Name = "dtp_purchasingdate";
            this.dtp_purchasingdate.Size = new System.Drawing.Size(160, 34);
            this.dtp_purchasingdate.TabIndex = 8;
            // 
            // dtp_returndate
            // 
            this.dtp_returndate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_returndate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_returndate.Location = new System.Drawing.Point(507, 355);
            this.dtp_returndate.Name = "dtp_returndate";
            this.dtp_returndate.Size = new System.Drawing.Size(160, 34);
            this.dtp_returndate.TabIndex = 9;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(531, 505);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(155, 40);
            this.btn_cancel.TabIndex = 58;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(182, 505);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(155, 40);
            this.btn_clear.TabIndex = 57;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(355, 505);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 40);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(12, 505);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 40);
            this.btn_save.TabIndex = 55;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_finalamount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_returndate);
            this.groupBox1.Controls.Add(this.dtp_purchasingdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_loanammount);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_interestrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_phoneno);
            this.groupBox1.Controls.Add(this.txt_city);
            this.groupBox1.Controls.Add(this.txt_Custid);
            this.groupBox1.Controls.Add(this.txt_custname);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_amount);
            this.groupBox1.Controls.Add(this.lbl_itemdiscout);
            this.groupBox1.Controls.Add(this.lbl_itemrate);
            this.groupBox1.Controls.Add(this.lbl_itemModule);
            this.groupBox1.Controls.Add(this.lbl_itemid);
            this.groupBox1.Controls.Add(this.lbl_itemno);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 446);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // txt_finalamount
            // 
            this.txt_finalamount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_finalamount.Location = new System.Drawing.Point(507, 398);
            this.txt_finalamount.Name = "txt_finalamount";
            this.txt_finalamount.Size = new System.Drawing.Size(160, 34);
            this.txt_finalamount.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(303, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 27);
            this.label5.TabIndex = 55;
            this.label5.Text = "Final Amount:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 555);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 225);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(701, 792);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Name = "frm_loan";
            this.Text = "frm_loan";
            this.Load += new System.EventHandler(this.frm_loan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_interestrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phoneno;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_Custid;
        private System.Windows.Forms.TextBox txt_custname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_itemdiscout;
        private System.Windows.Forms.Label lbl_itemrate;
        private System.Windows.Forms.Label lbl_itemModule;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_itemno;
        private System.Windows.Forms.TextBox txt_loanammount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_purchasingdate;
        private System.Windows.Forms.DateTimePicker dtp_returndate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_finalamount;
        private System.Windows.Forms.Label label5;
    }
}