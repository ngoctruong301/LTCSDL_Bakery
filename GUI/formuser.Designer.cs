namespace GUI
{
    partial class formuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formuser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lbqty = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbordersitemlist = new System.Windows.Forms.Label();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtproductid);
            this.panel1.Controls.Add(this.lbpassword);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.lbqty);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txtcategory);
            this.panel1.Controls.Add(this.lbuser);
            this.panel1.Location = new System.Drawing.Point(1, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 443);
            this.panel1.TabIndex = 5;
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
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.ForeColor = System.Drawing.Color.Teal;
            this.lbpassword.Location = new System.Drawing.Point(16, 78);
            this.lbpassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(75, 18);
            this.lbpassword.TabIndex = 13;
            this.lbpassword.Text = "Mật Khẩu";
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
            this.lbqty.Size = new System.Drawing.Size(114, 18);
            this.lbqty.TabIndex = 11;
            this.lbqty.Text = "Loại Tài Khoản";
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
            // txtcategory
            // 
            this.txtcategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcategory.Location = new System.Drawing.Point(11, 43);
            this.txtcategory.Multiline = true;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(324, 32);
            this.txtcategory.TabIndex = 5;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.ForeColor = System.Drawing.Color.Teal;
            this.lbuser.Location = new System.Drawing.Point(16, 22);
            this.lbuser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(80, 18);
            this.lbuser.TabIndex = 5;
            this.lbuser.Text = "Tài Khoản";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbordersitemlist);
            this.panel2.Controls.Add(this.dgvuser);
            this.panel2.Location = new System.Drawing.Point(389, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 443);
            this.panel2.TabIndex = 6;
            // 
            // lbordersitemlist
            // 
            this.lbordersitemlist.AutoSize = true;
            this.lbordersitemlist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbordersitemlist.ForeColor = System.Drawing.Color.Teal;
            this.lbordersitemlist.Location = new System.Drawing.Point(23, 22);
            this.lbordersitemlist.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbordersitemlist.Name = "lbordersitemlist";
            this.lbordersitemlist.Size = new System.Drawing.Size(160, 18);
            this.lbordersitemlist.TabIndex = 4;
            this.lbordersitemlist.Text = "Danh Sách Tài Khoản";
            // 
            // dgvuser
            // 
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(26, 55);
            this.dgvuser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowHeadersWidth = 62;
            this.dgvuser.Size = new System.Drawing.Size(417, 358);
            this.dgvuser.TabIndex = 0;
            this.dgvuser.SelectionChanged += new System.EventHandler(this.dgvuser_SelectionChanged);
            // 
            // formuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.formuser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lbqty;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbordersitemlist;
        private System.Windows.Forms.DataGridView dgvuser;
    }
}