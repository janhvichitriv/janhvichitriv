
namespace JewllaryShopManagment
{
    partial class frm_salesReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_percentofannualsale = new System.Windows.Forms.TextBox();
            this.txt_overallgrossvalue = new System.Windows.Forms.TextBox();
            this.txt_Grosssales = new System.Windows.Forms.TextBox();
            this.txt_totalsales = new System.Windows.Forms.TextBox();
            this.lbl_itemdiscout = new System.Windows.Forms.Label();
            this.lbl_itemrate = new System.Windows.Forms.Label();
            this.lbl_itemModule = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.lbl_itemno = new System.Windows.Forms.Label();
            this.txt_averagesalesvalue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sales Report Module";
            // 
            // txt_percentofannualsale
            // 
            this.txt_percentofannualsale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_percentofannualsale.Location = new System.Drawing.Point(525, 244);
            this.txt_percentofannualsale.Name = "txt_percentofannualsale";
            this.txt_percentofannualsale.Size = new System.Drawing.Size(160, 34);
            this.txt_percentofannualsale.TabIndex = 25;
            // 
            // txt_overallgrossvalue
            // 
            this.txt_overallgrossvalue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overallgrossvalue.Location = new System.Drawing.Point(525, 189);
            this.txt_overallgrossvalue.Name = "txt_overallgrossvalue";
            this.txt_overallgrossvalue.Size = new System.Drawing.Size(160, 34);
            this.txt_overallgrossvalue.TabIndex = 23;
            // 
            // txt_Grosssales
            // 
            this.txt_Grosssales.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Grosssales.Location = new System.Drawing.Point(525, 17);
            this.txt_Grosssales.Name = "txt_Grosssales";
            this.txt_Grosssales.Size = new System.Drawing.Size(160, 34);
            this.txt_Grosssales.TabIndex = 16;
            // 
            // txt_totalsales
            // 
            this.txt_totalsales.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalsales.Location = new System.Drawing.Point(525, 72);
            this.txt_totalsales.Name = "txt_totalsales";
            this.txt_totalsales.Size = new System.Drawing.Size(160, 34);
            this.txt_totalsales.TabIndex = 19;
            // 
            // lbl_itemdiscout
            // 
            this.lbl_itemdiscout.AutoSize = true;
            this.lbl_itemdiscout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemdiscout.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemdiscout.Location = new System.Drawing.Point(319, 244);
            this.lbl_itemdiscout.Name = "lbl_itemdiscout";
            this.lbl_itemdiscout.Size = new System.Drawing.Size(186, 27);
            this.lbl_itemdiscout.TabIndex = 22;
            this.lbl_itemdiscout.Text = "% of annual sales:";
            // 
            // lbl_itemrate
            // 
            this.lbl_itemrate.AutoSize = true;
            this.lbl_itemrate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemrate.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemrate.Location = new System.Drawing.Point(319, 189);
            this.lbl_itemrate.Name = "lbl_itemrate";
            this.lbl_itemrate.Size = new System.Drawing.Size(203, 27);
            this.lbl_itemrate.TabIndex = 20;
            this.lbl_itemrate.Text = "Overall gross profit:";
            // 
            // lbl_itemModule
            // 
            this.lbl_itemModule.AutoSize = true;
            this.lbl_itemModule.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemModule.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemModule.Location = new System.Drawing.Point(319, 134);
            this.lbl_itemModule.Name = "lbl_itemModule";
            this.lbl_itemModule.Size = new System.Drawing.Size(168, 27);
            this.lbl_itemModule.TabIndex = 18;
            this.lbl_itemModule.Text = "avg. sales value:";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemid.Location = new System.Drawing.Point(319, 79);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(121, 27);
            this.lbl_itemid.TabIndex = 17;
            this.lbl_itemid.Text = "Total Sales:";
            // 
            // lbl_itemno
            // 
            this.lbl_itemno.AutoSize = true;
            this.lbl_itemno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemno.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemno.Location = new System.Drawing.Point(319, 24);
            this.lbl_itemno.Name = "lbl_itemno";
            this.lbl_itemno.Size = new System.Drawing.Size(128, 27);
            this.lbl_itemno.TabIndex = 15;
            this.lbl_itemno.Text = "Gross Sales:";
            // 
            // txt_averagesalesvalue
            // 
            this.txt_averagesalesvalue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_averagesalesvalue.Location = new System.Drawing.Point(525, 127);
            this.txt_averagesalesvalue.Name = "txt_averagesalesvalue";
            this.txt_averagesalesvalue.Size = new System.Drawing.Size(160, 34);
            this.txt_averagesalesvalue.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_averagesalesvalue);
            this.groupBox1.Controls.Add(this.txt_percentofannualsale);
            this.groupBox1.Controls.Add(this.txt_overallgrossvalue);
            this.groupBox1.Controls.Add(this.txt_Grosssales);
            this.groupBox1.Controls.Add(this.txt_totalsales);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_itemdiscout);
            this.groupBox1.Controls.Add(this.lbl_itemrate);
            this.groupBox1.Controls.Add(this.lbl_itemModule);
            this.groupBox1.Controls.Add(this.lbl_itemid);
            this.groupBox1.Controls.Add(this.lbl_itemno);
            this.groupBox1.Location = new System.Drawing.Point(17, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 290);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 289);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(560, 350);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(155, 44);
            this.btn_cancel.TabIndex = 41;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(199, 350);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(155, 44);
            this.btn_clear.TabIndex = 40;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(384, 350);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 44);
            this.btn_delete.TabIndex = 39;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(15, 350);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 44);
            this.btn_save.TabIndex = 38;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::JewllaryShopManagment.Properties.Resources._21;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frm_salesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(731, 707);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_salesReport";
            this.Text = "frm_salesReport";
            this.Load += new System.EventHandler(this.frm_salesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_percentofannualsale;
        private System.Windows.Forms.TextBox txt_overallgrossvalue;
        private System.Windows.Forms.TextBox txt_Grosssales;
        private System.Windows.Forms.TextBox txt_totalsales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_itemdiscout;
        private System.Windows.Forms.Label lbl_itemrate;
        private System.Windows.Forms.Label lbl_itemModule;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_itemno;
        private System.Windows.Forms.TextBox txt_averagesalesvalue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
    }
}