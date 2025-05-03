namespace GUI
{
    partial class formordersitem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formordersitem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lbproductid = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lbqty = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtordersid = new System.Windows.Forms.TextBox();
            this.lbordersitem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbordersitemlist = new System.Windows.Forms.Label();
            this.dgvordersitem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordersitem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtproductid);
            this.panel1.Controls.Add(this.lbproductid);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.lbqty);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txtordersid);
            this.panel1.Controls.Add(this.lbordersitem);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 443);
            this.panel1.TabIndex = 4;
            // 
            // txtproductid
            // 
            this.txtproductid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtproductid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtproductid.Location = new System.Drawing.Point(11, 99);
            this.txtproductid.Multiline = true;
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(324, 32);
            this.txtproductid.TabIndex = 12;
            // 
            // lbproductid
            // 
            this.lbproductid.AutoSize = true;
            this.lbproductid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductid.ForeColor = System.Drawing.Color.Teal;
            this.lbproductid.Location = new System.Drawing.Point(16, 78);
            this.lbproductid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbproductid.Name = "lbproductid";
            this.lbproductid.Size = new System.Drawing.Size(161, 27);
            this.lbproductid.TabIndex = 13;
            this.lbproductid.Text = "Mã Sản Phẩm";
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtqty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtqty.Location = new System.Drawing.Point(11, 155);
            this.txtqty.Multiline = true;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(324, 32);
            this.txtqty.TabIndex = 10;
            // 
            // lbqty
            // 
            this.lbqty.AutoSize = true;
            this.lbqty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqty.ForeColor = System.Drawing.Color.Teal;
            this.lbqty.Location = new System.Drawing.Point(16, 134);
            this.lbqty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(123, 27);
            this.lbqty.TabIndex = 11;
            this.lbqty.Text = "Số Lượng";
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
            // txtordersid
            // 
            this.txtordersid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtordersid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtordersid.Location = new System.Drawing.Point(11, 43);
            this.txtordersid.Multiline = true;
            this.txtordersid.Name = "txtordersid";
            this.txtordersid.Size = new System.Drawing.Size(324, 32);
            this.txtordersid.TabIndex = 5;
            // 
            // lbordersitem
            // 
            this.lbordersitem.AutoSize = true;
            this.lbordersitem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbordersitem.ForeColor = System.Drawing.Color.Teal;
            this.lbordersitem.Location = new System.Drawing.Point(16, 22);
            this.lbordersitem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbordersitem.Name = "lbordersitem";
            this.lbordersitem.Size = new System.Drawing.Size(163, 27);
            this.lbordersitem.TabIndex = 5;
            this.lbordersitem.Text = "Mã Đơn Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbordersitemlist);
            this.panel2.Controls.Add(this.dgvordersitem);
            this.panel2.Location = new System.Drawing.Point(390, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 443);
            this.panel2.TabIndex = 5;
            // 
            // lbordersitemlist
            // 
            this.lbordersitemlist.AutoSize = true;
            this.lbordersitemlist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbordersitemlist.ForeColor = System.Drawing.Color.Teal;
            this.lbordersitemlist.Location = new System.Drawing.Point(23, 22);
            this.lbordersitemlist.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbordersitemlist.Name = "lbordersitemlist";
            this.lbordersitemlist.Size = new System.Drawing.Size(219, 27);
            this.lbordersitemlist.TabIndex = 4;
            this.lbordersitemlist.Text = "Chi Tiết Đơn Hàng";
            // 
            // dgvordersitem
            // 
            this.dgvordersitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvordersitem.Location = new System.Drawing.Point(26, 55);
            this.dgvordersitem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvordersitem.Name = "dgvordersitem";
            this.dgvordersitem.RowHeadersWidth = 62;
            this.dgvordersitem.Size = new System.Drawing.Size(417, 358);
            this.dgvordersitem.TabIndex = 0;
            this.dgvordersitem.SelectionChanged += new System.EventHandler(this.dgvordersitem_SelectionChanged);
            // 
            // formordersitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formordersitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Đơn Hàng";
            this.Load += new System.EventHandler(this.formordersitem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordersitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtordersid;
        private System.Windows.Forms.Label lbordersitem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbordersitemlist;
        private System.Windows.Forms.DataGridView dgvordersitem;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lbproductid;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lbqty;
    }
}