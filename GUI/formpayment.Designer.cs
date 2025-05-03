namespace GUI
{
    partial class formpayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formpayment));
            this.pnpayment = new System.Windows.Forms.Panel();
            this.cbopayment = new System.Windows.Forms.ComboBox();
            this.lbHinhthuc = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.lborderid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbpayment = new System.Windows.Forms.Label();
            this.dgvpayment = new System.Windows.Forms.DataGridView();
            this.cboordersid = new System.Windows.Forms.ComboBox();
            this.txtpaymentid = new System.Windows.Forms.TextBox();
            this.lbpaymentid = new System.Windows.Forms.Label();
            this.pnpayment.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).BeginInit();
            this.SuspendLayout();
            // 
            // pnpayment
            // 
            this.pnpayment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnpayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnpayment.Controls.Add(this.txtpaymentid);
            this.pnpayment.Controls.Add(this.lbpaymentid);
            this.pnpayment.Controls.Add(this.cboordersid);
            this.pnpayment.Controls.Add(this.cbopayment);
            this.pnpayment.Controls.Add(this.lbHinhthuc);
            this.pnpayment.Controls.Add(this.txttotal);
            this.pnpayment.Controls.Add(this.lbtotal);
            this.pnpayment.Controls.Add(this.btnupdate);
            this.pnpayment.Controls.Add(this.btnclear);
            this.pnpayment.Controls.Add(this.btndelete);
            this.pnpayment.Controls.Add(this.btninsert);
            this.pnpayment.Controls.Add(this.lborderid);
            this.pnpayment.Location = new System.Drawing.Point(5, 13);
            this.pnpayment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnpayment.Name = "pnpayment";
            this.pnpayment.Size = new System.Drawing.Size(363, 443);
            this.pnpayment.TabIndex = 8;
            // 
            // cbopayment
            // 
            this.cbopayment.FormattingEnabled = true;
            this.cbopayment.Location = new System.Drawing.Point(11, 132);
            this.cbopayment.Name = "cbopayment";
            this.cbopayment.Size = new System.Drawing.Size(325, 24);
            this.cbopayment.TabIndex = 14;
            // 
            // lbHinhthuc
            // 
            this.lbHinhthuc.AutoSize = true;
            this.lbHinhthuc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinhthuc.ForeColor = System.Drawing.Color.Teal;
            this.lbHinhthuc.Location = new System.Drawing.Point(16, 111);
            this.lbHinhthuc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbHinhthuc.Name = "lbHinhthuc";
            this.lbHinhthuc.Size = new System.Drawing.Size(83, 18);
            this.lbHinhthuc.TabIndex = 13;
            this.lbHinhthuc.Text = "Hình Thức";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttotal.Location = new System.Drawing.Point(11, 180);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(324, 32);
            this.txttotal.TabIndex = 10;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.ForeColor = System.Drawing.Color.Teal;
            this.lbtotal.Location = new System.Drawing.Point(16, 159);
            this.lbtotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(63, 18);
            this.lbtotal.TabIndex = 11;
            this.lbtotal.Text = "Số Tiền";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Teal;
            this.btnupdate.Location = new System.Drawing.Point(10, 342);
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
            this.btnclear.Location = new System.Drawing.Point(202, 342);
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
            this.btndelete.Location = new System.Drawing.Point(202, 231);
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
            this.btninsert.Location = new System.Drawing.Point(10, 231);
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
            this.lborderid.Location = new System.Drawing.Point(16, 63);
            this.lborderid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lborderid.Name = "lborderid";
            this.lborderid.Size = new System.Drawing.Size(105, 18);
            this.lborderid.TabIndex = 5;
            this.lborderid.Text = "Mã Đơn Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbpayment);
            this.panel2.Controls.Add(this.dgvpayment);
            this.panel2.Location = new System.Drawing.Point(392, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 443);
            this.panel2.TabIndex = 9;
            // 
            // lbpayment
            // 
            this.lbpayment.AutoSize = true;
            this.lbpayment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpayment.ForeColor = System.Drawing.Color.Teal;
            this.lbpayment.Location = new System.Drawing.Point(23, 22);
            this.lbpayment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbpayment.Name = "lbpayment";
            this.lbpayment.Size = new System.Drawing.Size(152, 18);
            this.lbpayment.TabIndex = 4;
            this.lbpayment.Text = "Chi Tiết Thanh Toán";
            // 
            // dgvpayment
            // 
            this.dgvpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayment.Location = new System.Drawing.Point(26, 55);
            this.dgvpayment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvpayment.Name = "dgvpayment";
            this.dgvpayment.RowHeadersWidth = 62;
            this.dgvpayment.Size = new System.Drawing.Size(417, 358);
            this.dgvpayment.TabIndex = 0;
            this.dgvpayment.SelectionChanged += new System.EventHandler(this.dgvpayment_SelectionChanged);
            // 
            // cboordersid
            // 
            this.cboordersid.FormattingEnabled = true;
            this.cboordersid.Location = new System.Drawing.Point(10, 84);
            this.cboordersid.Name = "cboordersid";
            this.cboordersid.Size = new System.Drawing.Size(326, 24);
            this.cboordersid.TabIndex = 15;
            // 
            // txtpaymentid
            // 
            this.txtpaymentid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpaymentid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpaymentid.Location = new System.Drawing.Point(10, 28);
            this.txtpaymentid.Multiline = true;
            this.txtpaymentid.Name = "txtpaymentid";
            this.txtpaymentid.Size = new System.Drawing.Size(324, 32);
            this.txtpaymentid.TabIndex = 16;
            // 
            // lbpaymentid
            // 
            this.lbpaymentid.AutoSize = true;
            this.lbpaymentid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpaymentid.ForeColor = System.Drawing.Color.Teal;
            this.lbpaymentid.Location = new System.Drawing.Point(15, 7);
            this.lbpaymentid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbpaymentid.Name = "lbpaymentid";
            this.lbpaymentid.Size = new System.Drawing.Size(117, 18);
            this.lbpaymentid.TabIndex = 17;
            this.lbpaymentid.Text = "Mã Thanh Toán";
            // 
            // formpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.pnpayment);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.formpayment_Load);
            this.pnpayment.ResumeLayout(false);
            this.pnpayment.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnpayment;
        private System.Windows.Forms.Label lbHinhthuc;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label lborderid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbpayment;
        private System.Windows.Forms.DataGridView dgvpayment;
        private System.Windows.Forms.ComboBox cbopayment;
        private System.Windows.Forms.ComboBox cboordersid;
        private System.Windows.Forms.TextBox txtpaymentid;
        private System.Windows.Forms.Label lbpaymentid;
    }
}