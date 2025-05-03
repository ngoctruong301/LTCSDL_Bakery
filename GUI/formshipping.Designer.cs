namespace GUI
{
    partial class formshipping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formshipping));
            this.pnorderid = new System.Windows.Forms.Panel();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.lborderid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbshippinglist = new System.Windows.Forms.Label();
            this.dgvshipping = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.pnorderid.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshipping)).BeginInit();
            this.SuspendLayout();
            // 
            // pnorderid
            // 
            this.pnorderid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnorderid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnorderid.Controls.Add(this.cbostatus);
            this.pnorderid.Controls.Add(this.cbocategory);
            this.pnorderid.Controls.Add(this.txtsdt);
            this.pnorderid.Controls.Add(this.label1);
            this.pnorderid.Controls.Add(this.txtaddress);
            this.pnorderid.Controls.Add(this.lbaddress);
            this.pnorderid.Controls.Add(this.lbstatus);
            this.pnorderid.Controls.Add(this.btnupdate);
            this.pnorderid.Controls.Add(this.btnclear);
            this.pnorderid.Controls.Add(this.btndelete);
            this.pnorderid.Controls.Add(this.btninsert);
            this.pnorderid.Controls.Add(this.lborderid);
            this.pnorderid.Location = new System.Drawing.Point(3, 4);
            this.pnorderid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnorderid.Name = "pnorderid";
            this.pnorderid.Size = new System.Drawing.Size(363, 496);
            this.pnorderid.TabIndex = 8;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtaddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtaddress.Location = new System.Drawing.Point(11, 99);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(324, 32);
            this.txtaddress.TabIndex = 12;
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.Color.Teal;
            this.lbaddress.Location = new System.Drawing.Point(16, 78);
            this.lbaddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(94, 27);
            this.lbaddress.TabIndex = 13;
            this.lbaddress.Text = "Địa Chỉ";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.ForeColor = System.Drawing.Color.Teal;
            this.lbstatus.Location = new System.Drawing.Point(16, 134);
            this.lbstatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(133, 27);
            this.lbstatus.TabIndex = 11;
            this.lbstatus.Text = "Trạng Thái";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Teal;
            this.btnupdate.Location = new System.Drawing.Point(11, 397);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(144, 71);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Teal;
            this.btnclear.Location = new System.Drawing.Point(202, 397);
            this.btnclear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(144, 71);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Đặt Lại";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.NavajoWhite;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Teal;
            this.btndelete.Location = new System.Drawing.Point(202, 270);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(144, 71);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Xoá";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.NavajoWhite;
            this.btninsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.Teal;
            this.btninsert.Location = new System.Drawing.Point(10, 270);
            this.btninsert.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(144, 71);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Thêm";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lborderid
            // 
            this.lborderid.AutoSize = true;
            this.lborderid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborderid.ForeColor = System.Drawing.Color.Teal;
            this.lborderid.Location = new System.Drawing.Point(16, 22);
            this.lborderid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lborderid.Name = "lborderid";
            this.lborderid.Size = new System.Drawing.Size(163, 27);
            this.lborderid.TabIndex = 5;
            this.lborderid.Text = "Mã Đơn Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbshippinglist);
            this.panel2.Controls.Add(this.dgvshipping);
            this.panel2.Location = new System.Drawing.Point(390, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 496);
            this.panel2.TabIndex = 9;
            // 
            // lbshippinglist
            // 
            this.lbshippinglist.AutoSize = true;
            this.lbshippinglist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbshippinglist.ForeColor = System.Drawing.Color.Teal;
            this.lbshippinglist.Location = new System.Drawing.Point(23, 22);
            this.lbshippinglist.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbshippinglist.Name = "lbshippinglist";
            this.lbshippinglist.Size = new System.Drawing.Size(253, 27);
            this.lbshippinglist.TabIndex = 4;
            this.lbshippinglist.Text = "Danh Sách Đơn Hàng";
            // 
            // dgvshipping
            // 
            this.dgvshipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshipping.Location = new System.Drawing.Point(26, 55);
            this.dgvshipping.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvshipping.Name = "dgvshipping";
            this.dgvshipping.RowHeadersWidth = 62;
            this.dgvshipping.Size = new System.Drawing.Size(417, 430);
            this.dgvshipping.TabIndex = 0;
            this.dgvshipping.SelectionChanged += new System.EventHandler(this.dgvshipping_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(16, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "SĐT";
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsdt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsdt.Location = new System.Drawing.Point(11, 211);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(324, 32);
            this.txtsdt.TabIndex = 15;
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(11, 52);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(324, 32);
            this.cbocategory.TabIndex = 16;
            // 
            // cbostatus
            // 
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Location = new System.Drawing.Point(11, 155);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(324, 32);
            this.cbostatus.TabIndex = 17;
            // 
            // formshipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 503);
            this.Controls.Add(this.pnorderid);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formshipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Hàng";
            this.Load += new System.EventHandler(this.formshipping_Load);
            this.pnorderid.ResumeLayout(false);
            this.pnorderid.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshipping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnorderid;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label lborderid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbshippinglist;
        private System.Windows.Forms.DataGridView dgvshipping;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbostatus;
        private System.Windows.Forms.ComboBox cbocategory;
    }
}