
namespace JewllaryShopManagment
{
    partial class frm_purchasingRmodule
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
            this.lbox_itemmodel = new System.Windows.Forms.ListBox();
            this.txt_phoneno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_orderdetail = new System.Windows.Forms.TextBox();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.txt_custname = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_itemdiscout = new System.Windows.Forms.Label();
            this.lbl_itemrate = new System.Windows.Forms.Label();
            this.lbl_itemModule = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.lbl_itemno = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox_itemmodel
            // 
            this.lbox_itemmodel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_itemmodel.FormattingEnabled = true;
            this.lbox_itemmodel.ItemHeight = 26;
            this.lbox_itemmodel.Items.AddRange(new object[] {
            "Ring",
            "Chain",
            "Bangles",
            "Ear-Rings",
            "Coin"});
            this.lbox_itemmodel.Location = new System.Drawing.Point(485, 179);
            this.lbox_itemmodel.Name = "lbox_itemmodel";
            this.lbox_itemmodel.Size = new System.Drawing.Size(160, 30);
            this.lbox_itemmodel.TabIndex = 6;
            this.lbox_itemmodel.Leave += new System.EventHandler(this.lbox_itemmodel_Leave);
            // 
            // txt_phoneno
            // 
            this.txt_phoneno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneno.Location = new System.Drawing.Point(485, 124);
            this.txt_phoneno.Name = "txt_phoneno";
            this.txt_phoneno.Size = new System.Drawing.Size(160, 34);
            this.txt_phoneno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(312, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 27);
            this.label2.TabIndex = 50;
            this.label2.Text = "Dilevery date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "Purchasing Report Module";
            // 
            // txt_orderdetail
            // 
            this.txt_orderdetail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderdetail.Location = new System.Drawing.Point(485, 234);
            this.txt_orderdetail.Name = "txt_orderdetail";
            this.txt_orderdetail.Size = new System.Drawing.Size(160, 34);
            this.txt_orderdetail.TabIndex = 5;
            // 
            // txt_itemid
            // 
            this.txt_itemid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemid.Location = new System.Drawing.Point(485, 286);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(160, 34);
            this.txt_itemid.TabIndex = 4;
            // 
            // txt_custname
            // 
            this.txt_custname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_custname.Location = new System.Drawing.Point(485, 14);
            this.txt_custname.Name = "txt_custname";
            this.txt_custname.Size = new System.Drawing.Size(160, 34);
            this.txt_custname.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(485, 62);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(160, 34);
            this.txt_address.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::JewllaryShopManagment.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(5, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_amount.Location = new System.Drawing.Point(312, 182);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(130, 27);
            this.lbl_amount.TabIndex = 43;
            this.lbl_amount.Text = "Item Model:";
            // 
            // lbl_itemdiscout
            // 
            this.lbl_itemdiscout.AutoSize = true;
            this.lbl_itemdiscout.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemdiscout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemdiscout.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemdiscout.Location = new System.Drawing.Point(312, 241);
            this.lbl_itemdiscout.Name = "lbl_itemdiscout";
            this.lbl_itemdiscout.Size = new System.Drawing.Size(133, 27);
            this.lbl_itemdiscout.TabIndex = 42;
            this.lbl_itemdiscout.Text = "Order detail:";
            // 
            // lbl_itemrate
            // 
            this.lbl_itemrate.AutoSize = true;
            this.lbl_itemrate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemrate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemrate.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemrate.Location = new System.Drawing.Point(312, 293);
            this.lbl_itemrate.Name = "lbl_itemrate";
            this.lbl_itemrate.Size = new System.Drawing.Size(86, 27);
            this.lbl_itemrate.TabIndex = 41;
            this.lbl_itemrate.Text = "Item id:";
            // 
            // lbl_itemModule
            // 
            this.lbl_itemModule.AutoSize = true;
            this.lbl_itemModule.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemModule.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemModule.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemModule.Location = new System.Drawing.Point(312, 124);
            this.lbl_itemModule.Name = "lbl_itemModule";
            this.lbl_itemModule.Size = new System.Drawing.Size(109, 27);
            this.lbl_itemModule.TabIndex = 40;
            this.lbl_itemModule.Text = "Phone no:";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemid.Location = new System.Drawing.Point(312, 69);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(96, 27);
            this.lbl_itemid.TabIndex = 39;
            this.lbl_itemid.Text = "Address:";
            // 
            // lbl_itemno
            // 
            this.lbl_itemno.AutoSize = true;
            this.lbl_itemno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemno.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemno.Location = new System.Drawing.Point(310, 18);
            this.lbl_itemno.Name = "lbl_itemno";
            this.lbl_itemno.Size = new System.Drawing.Size(169, 27);
            this.lbl_itemno.TabIndex = 38;
            this.lbl_itemno.Text = "Customer name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(485, 344);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 34);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 11, 21, 4, 2, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(24, 499);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 230);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lbox_itemmodel);
            this.groupBox1.Controls.Add(this.txt_phoneno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_orderdetail);
            this.groupBox1.Controls.Add(this.txt_itemid);
            this.groupBox1.Controls.Add(this.txt_custname);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_amount);
            this.groupBox1.Controls.Add(this.lbl_itemdiscout);
            this.groupBox1.Controls.Add(this.lbl_itemrate);
            this.groupBox1.Controls.Add(this.lbl_itemModule);
            this.groupBox1.Controls.Add(this.lbl_itemid);
            this.groupBox1.Controls.Add(this.lbl_itemno);
            this.groupBox1.Location = new System.Drawing.Point(25, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 393);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(537, 449);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(155, 44);
            this.btn_cancel.TabIndex = 54;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(195, 449);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(155, 44);
            this.btn_clear.TabIndex = 53;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(367, 449);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 44);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(24, 449);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 44);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // frm_purchasingRmodule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(716, 755);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Name = "frm_purchasingRmodule";
            this.Text = "frm_purchasingRmodule";
            this.Load += new System.EventHandler(this.frm_purchasingRmodule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_itemmodel;
        private System.Windows.Forms.TextBox txt_phoneno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_orderdetail;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.TextBox txt_custname;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_itemdiscout;
        private System.Windows.Forms.Label lbl_itemrate;
        private System.Windows.Forms.Label lbl_itemModule;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_itemno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
    }
}