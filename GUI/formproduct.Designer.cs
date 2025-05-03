
namespace GUI
{
    partial class formproduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formproduct));
            this.txtprice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcategoryid = new System.Windows.Forms.TextBox();
            this.lbcategory = new System.Windows.Forms.Label();
            this.txtsupplierid = new System.Windows.Forms.TextBox();
            this.lbsupplierid = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lbprice = new System.Windows.Forms.Label();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.lbproduct = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lbproductid = new System.Windows.Forms.Label();
            this.dgvproductlist = new System.Windows.Forms.DataGridView();
            this.lbproductlist = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductlist)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtprice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtprice.Location = new System.Drawing.Point(13, 145);
            this.txtprice.Margin = new System.Windows.Forms.Padding(1);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(324, 32);
            this.txtprice.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtcategoryid);
            this.panel1.Controls.Add(this.lbcategory);
            this.panel1.Controls.Add(this.txtsupplierid);
            this.panel1.Controls.Add(this.lbsupplierid);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.lbprice);
            this.panel1.Controls.Add(this.txtproduct);
            this.panel1.Controls.Add(this.lbproduct);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.lbproductid);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 514);
            this.panel1.TabIndex = 7;
            // 
            // txtcategoryid
            // 
            this.txtcategoryid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcategoryid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcategoryid.Location = new System.Drawing.Point(13, 249);
            this.txtcategoryid.Margin = new System.Windows.Forms.Padding(1);
            this.txtcategoryid.Multiline = true;
            this.txtcategoryid.Name = "txtcategoryid";
            this.txtcategoryid.Size = new System.Drawing.Size(324, 31);
            this.txtcategoryid.TabIndex = 17;
            // 
            // lbcategory
            // 
            this.lbcategory.AutoSize = true;
            this.lbcategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcategory.ForeColor = System.Drawing.Color.Teal;
            this.lbcategory.Location = new System.Drawing.Point(17, 230);
            this.lbcategory.Name = "lbcategory";
            this.lbcategory.Size = new System.Drawing.Size(163, 27);
            this.lbcategory.TabIndex = 18;
            this.lbcategory.Text = "Mã Danh Mục";
            // 
            // txtsupplierid
            // 
            this.txtsupplierid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsupplierid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsupplierid.Location = new System.Drawing.Point(13, 197);
            this.txtsupplierid.Margin = new System.Windows.Forms.Padding(1);
            this.txtsupplierid.Multiline = true;
            this.txtsupplierid.Name = "txtsupplierid";
            this.txtsupplierid.Size = new System.Drawing.Size(324, 32);
            this.txtsupplierid.TabIndex = 15;
            // 
            // lbsupplierid
            // 
            this.lbsupplierid.AutoSize = true;
            this.lbsupplierid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsupplierid.ForeColor = System.Drawing.Color.Teal;
            this.lbsupplierid.Location = new System.Drawing.Point(17, 178);
            this.lbsupplierid.Name = "lbsupplierid";
            this.lbsupplierid.Size = new System.Drawing.Size(101, 27);
            this.lbsupplierid.TabIndex = 16;
            this.lbsupplierid.Text = "Mã NCC";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Teal;
            this.btnupdate.Location = new System.Drawing.Point(8, 414);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(144, 71);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.ForeColor = System.Drawing.Color.Teal;
            this.lbprice.Location = new System.Drawing.Point(17, 126);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(106, 27);
            this.lbprice.TabIndex = 13;
            this.lbprice.Text = "Giá Tiền";
            // 
            // txtproduct
            // 
            this.txtproduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtproduct.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtproduct.Location = new System.Drawing.Point(13, 93);
            this.txtproduct.Margin = new System.Windows.Forms.Padding(1);
            this.txtproduct.Multiline = true;
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(324, 31);
            this.txtproduct.TabIndex = 10;
            // 
            // lbproduct
            // 
            this.lbproduct.AutoSize = true;
            this.lbproduct.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproduct.ForeColor = System.Drawing.Color.Teal;
            this.lbproduct.Location = new System.Drawing.Point(17, 74);
            this.lbproduct.Name = "lbproduct";
            this.lbproduct.Size = new System.Drawing.Size(172, 27);
            this.lbproduct.TabIndex = 11;
            this.lbproduct.Text = "Tên Sản Phẩm";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Teal;
            this.btnclear.Location = new System.Drawing.Point(201, 414);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btndelete.Location = new System.Drawing.Point(201, 310);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btninsert.Location = new System.Drawing.Point(8, 310);
            this.btninsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(144, 71);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Thêm";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtuser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtuser.Location = new System.Drawing.Point(13, 37);
            this.txtuser.Margin = new System.Windows.Forms.Padding(1);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(324, 31);
            this.txtuser.TabIndex = 5;
            // 
            // lbproductid
            // 
            this.lbproductid.AutoSize = true;
            this.lbproductid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductid.ForeColor = System.Drawing.Color.Teal;
            this.lbproductid.Location = new System.Drawing.Point(17, 18);
            this.lbproductid.Name = "lbproductid";
            this.lbproductid.Size = new System.Drawing.Size(161, 27);
            this.lbproductid.TabIndex = 5;
            this.lbproductid.Text = "Mã Sản Phẩm";
            // 
            // dgvproductlist
            // 
            this.dgvproductlist.AllowUserToAddRows = false;
            this.dgvproductlist.AllowUserToDeleteRows = false;
            this.dgvproductlist.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvproductlist.Location = new System.Drawing.Point(23, 38);
            this.dgvproductlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvproductlist.Name = "dgvproductlist";
            this.dgvproductlist.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproductlist.RowHeadersWidth = 62;
            this.dgvproductlist.Size = new System.Drawing.Size(483, 447);
            this.dgvproductlist.TabIndex = 0;
            this.dgvproductlist.SelectionChanged += new System.EventHandler(this.dgvproductlist_SelectionChanged);
            // 
            // lbproductlist
            // 
            this.lbproductlist.AutoSize = true;
            this.lbproductlist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductlist.ForeColor = System.Drawing.Color.Teal;
            this.lbproductlist.Location = new System.Drawing.Point(20, 18);
            this.lbproductlist.Name = "lbproductlist";
            this.lbproductlist.Size = new System.Drawing.Size(251, 27);
            this.lbproductlist.TabIndex = 4;
            this.lbproductlist.Text = "Danh Sách Sản Phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbproductlist);
            this.panel2.Controls.Add(this.dgvproductlist);
            this.panel2.Location = new System.Drawing.Point(401, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 514);
            this.panel2.TabIndex = 6;
            // 
            // formproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(934, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.formproduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductlist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.Label lbproduct;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lbproductid;
        private System.Windows.Forms.DataGridView dgvproductlist;
        private System.Windows.Forms.Label lbproductlist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtcategoryid;
        private System.Windows.Forms.Label lbcategory;
        private System.Windows.Forms.TextBox txtsupplierid;
        private System.Windows.Forms.Label lbsupplierid;
    }
}