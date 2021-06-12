
namespace JewllaryShopManagment
{
    partial class frm_RateModule
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
            this.lbl_itemno = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.lbl_itemModule = new System.Windows.Forms.Label();
            this.lbl_itemrate = new System.Windows.Forms.Label();
            this.lbl_itemdiscout = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.txt_itemno = new System.Windows.Forms.TextBox();
            this.txt_itemrate = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbox_itemmodel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_itemno
            // 
            this.lbl_itemno.AutoSize = true;
            this.lbl_itemno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemno.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemno.Location = new System.Drawing.Point(324, 37);
            this.lbl_itemno.Name = "lbl_itemno";
            this.lbl_itemno.Size = new System.Drawing.Size(97, 27);
            this.lbl_itemno.TabIndex = 0;
            this.lbl_itemno.Text = "Item No:";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemid.Location = new System.Drawing.Point(324, 147);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(88, 27);
            this.lbl_itemid.TabIndex = 1;
            this.lbl_itemid.Text = "Item Id:";
            // 
            // lbl_itemModule
            // 
            this.lbl_itemModule.AutoSize = true;
            this.lbl_itemModule.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemModule.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemModule.Location = new System.Drawing.Point(324, 92);
            this.lbl_itemModule.Name = "lbl_itemModule";
            this.lbl_itemModule.Size = new System.Drawing.Size(130, 27);
            this.lbl_itemModule.TabIndex = 2;
            this.lbl_itemModule.Text = "Item Model:";
            // 
            // lbl_itemrate
            // 
            this.lbl_itemrate.AutoSize = true;
            this.lbl_itemrate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemrate.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemrate.Location = new System.Drawing.Point(324, 202);
            this.lbl_itemrate.Name = "lbl_itemrate";
            this.lbl_itemrate.Size = new System.Drawing.Size(63, 27);
            this.lbl_itemrate.TabIndex = 3;
            this.lbl_itemrate.Text = "Rate:";
            // 
            // lbl_itemdiscout
            // 
            this.lbl_itemdiscout.AutoSize = true;
            this.lbl_itemdiscout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemdiscout.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemdiscout.Location = new System.Drawing.Point(324, 257);
            this.lbl_itemdiscout.Name = "lbl_itemdiscout";
            this.lbl_itemdiscout.Size = new System.Drawing.Size(104, 27);
            this.lbl_itemdiscout.TabIndex = 4;
            this.lbl_itemdiscout.Text = "Discount:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_amount.Location = new System.Drawing.Point(324, 312);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(96, 27);
            this.lbl_amount.TabIndex = 5;
            this.lbl_amount.Text = "Amount:";
            // 
            // txt_itemid
            // 
            this.txt_itemid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemid.Location = new System.Drawing.Point(497, 140);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(160, 34);
            this.txt_itemid.TabIndex = 3;
            // 
            // txt_itemno
            // 
            this.txt_itemno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemno.Location = new System.Drawing.Point(497, 30);
            this.txt_itemno.Name = "txt_itemno";
            this.txt_itemno.Size = new System.Drawing.Size(160, 34);
            this.txt_itemno.TabIndex = 1;
            // 
            // txt_itemrate
            // 
            this.txt_itemrate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemrate.Location = new System.Drawing.Point(497, 202);
            this.txt_itemrate.Name = "txt_itemrate";
            this.txt_itemrate.Size = new System.Drawing.Size(160, 34);
            this.txt_itemrate.TabIndex = 4;
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(497, 257);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(160, 34);
            this.txt_discount.TabIndex = 5;
            this.txt_discount.Leave += new System.EventHandler(this.txt_discount_Leave_1);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(497, 309);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(160, 34);
            this.txt_amount.TabIndex = 6;
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
            this.lbox_itemmodel.Location = new System.Drawing.Point(497, 89);
            this.lbox_itemmodel.Name = "lbox_itemmodel";
            this.lbox_itemmodel.Size = new System.Drawing.Size(160, 30);
            this.lbox_itemmodel.TabIndex = 2;
            this.lbox_itemmodel.Leave += new System.EventHandler(this.lbox_itemmodel_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(264, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rate Module";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Black;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(555, 426);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(155, 44);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Black;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(199, 426);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(155, 44);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(377, 426);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 44);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(21, 426);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 44);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbox_itemmodel);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.txt_discount);
            this.groupBox1.Controls.Add(this.txt_itemrate);
            this.groupBox1.Controls.Add(this.txt_itemno);
            this.groupBox1.Controls.Add(this.txt_itemid);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_amount);
            this.groupBox1.Controls.Add(this.lbl_itemdiscout);
            this.groupBox1.Controls.Add(this.lbl_itemrate);
            this.groupBox1.Controls.Add(this.lbl_itemModule);
            this.groupBox1.Controls.Add(this.lbl_itemid);
            this.groupBox1.Controls.Add(this.lbl_itemno);
            this.groupBox1.Location = new System.Drawing.Point(21, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 360);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 476);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 240);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::JewllaryShopManagment.Properties.Resources._12;
            this.pictureBox1.Location = new System.Drawing.Point(17, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_RateModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(746, 763);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Name = "frm_RateModule";
            this.Text = "RateModule";
            this.Load += new System.EventHandler(this.frm_RateModule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_itemno;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_itemModule;
        private System.Windows.Forms.Label lbl_itemrate;
        private System.Windows.Forms.Label lbl_itemdiscout;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.TextBox txt_itemno;
        private System.Windows.Forms.TextBox txt_itemrate;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ListBox lbox_itemmodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}