namespace GUI
{
    partial class formpromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formpromotion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.lbend = new System.Windows.Forms.Label();
            this.lbstart = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lbdiscount = new System.Windows.Forms.Label();
            this.txtpromotion = new System.Windows.Forms.TextBox();
            this.lbpromotion = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtpromotionid = new System.Windows.Forms.TextBox();
            this.lbpromotionid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbproductlist = new System.Windows.Forms.Label();
            this.dgvpromotion = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpromotion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpend);
            this.panel1.Controls.Add(this.dtpstart);
            this.panel1.Controls.Add(this.lbend);
            this.panel1.Controls.Add(this.lbstart);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.lbdiscount);
            this.panel1.Controls.Add(this.txtpromotion);
            this.panel1.Controls.Add(this.lbpromotion);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txtpromotionid);
            this.panel1.Controls.Add(this.lbpromotionid);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 514);
            this.panel1.TabIndex = 11;
            // 
            // dtpend
            // 
            this.dtpend.Location = new System.Drawing.Point(13, 251);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(324, 26);
            this.dtpend.TabIndex = 20;
            // 
            // dtpstart
            // 
            this.dtpstart.Location = new System.Drawing.Point(13, 199);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(324, 26);
            this.dtpstart.TabIndex = 19;
            // 
            // lbend
            // 
            this.lbend.AutoSize = true;
            this.lbend.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbend.ForeColor = System.Drawing.Color.Teal;
            this.lbend.Location = new System.Drawing.Point(17, 230);
            this.lbend.Name = "lbend";
            this.lbend.Size = new System.Drawing.Size(174, 27);
            this.lbend.TabIndex = 18;
            this.lbend.Text = "Ngày Kết Thúc";
            // 
            // lbstart
            // 
            this.lbstart.AutoSize = true;
            this.lbstart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstart.ForeColor = System.Drawing.Color.Teal;
            this.lbstart.Location = new System.Drawing.Point(17, 178);
            this.lbstart.Name = "lbstart";
            this.lbstart.Size = new System.Drawing.Size(162, 27);
            this.lbstart.TabIndex = 16;
            this.lbstart.Text = "Ngày Bắt Đầu";
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
            // txtdiscount
            // 
            this.txtdiscount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdiscount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdiscount.Location = new System.Drawing.Point(13, 145);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(1);
            this.txtdiscount.Multiline = true;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(324, 32);
            this.txtdiscount.TabIndex = 12;
            // 
            // lbdiscount
            // 
            this.lbdiscount.AutoSize = true;
            this.lbdiscount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiscount.ForeColor = System.Drawing.Color.Teal;
            this.lbdiscount.Location = new System.Drawing.Point(17, 126);
            this.lbdiscount.Name = "lbdiscount";
            this.lbdiscount.Size = new System.Drawing.Size(160, 27);
            this.lbdiscount.TabIndex = 13;
            this.lbdiscount.Text = "Số Tiền Giảm";
            // 
            // txtpromotion
            // 
            this.txtpromotion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpromotion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpromotion.Location = new System.Drawing.Point(13, 93);
            this.txtpromotion.Margin = new System.Windows.Forms.Padding(1);
            this.txtpromotion.Multiline = true;
            this.txtpromotion.Name = "txtpromotion";
            this.txtpromotion.Size = new System.Drawing.Size(324, 31);
            this.txtpromotion.TabIndex = 10;
            // 
            // lbpromotion
            // 
            this.lbpromotion.AutoSize = true;
            this.lbpromotion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpromotion.ForeColor = System.Drawing.Color.Teal;
            this.lbpromotion.Location = new System.Drawing.Point(17, 74);
            this.lbpromotion.Name = "lbpromotion";
            this.lbpromotion.Size = new System.Drawing.Size(192, 27);
            this.lbpromotion.TabIndex = 11;
            this.lbpromotion.Text = "Tên Khuyến Mãi";
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
            // txtpromotionid
            // 
            this.txtpromotionid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpromotionid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpromotionid.Location = new System.Drawing.Point(13, 37);
            this.txtpromotionid.Margin = new System.Windows.Forms.Padding(1);
            this.txtpromotionid.Multiline = true;
            this.txtpromotionid.Name = "txtpromotionid";
            this.txtpromotionid.Size = new System.Drawing.Size(324, 31);
            this.txtpromotionid.TabIndex = 5;
            // 
            // lbpromotionid
            // 
            this.lbpromotionid.AutoSize = true;
            this.lbpromotionid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpromotionid.ForeColor = System.Drawing.Color.Teal;
            this.lbpromotionid.Location = new System.Drawing.Point(17, 18);
            this.lbpromotionid.Name = "lbpromotionid";
            this.lbpromotionid.Size = new System.Drawing.Size(181, 27);
            this.lbpromotionid.TabIndex = 5;
            this.lbpromotionid.Text = "Mã Khuyến Mãi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbproductlist);
            this.panel2.Controls.Add(this.dgvpromotion);
            this.panel2.Location = new System.Drawing.Point(404, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 514);
            this.panel2.TabIndex = 10;
            // 
            // lbproductlist
            // 
            this.lbproductlist.AutoSize = true;
            this.lbproductlist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductlist.ForeColor = System.Drawing.Color.Teal;
            this.lbproductlist.Location = new System.Drawing.Point(20, 18);
            this.lbproductlist.Name = "lbproductlist";
            this.lbproductlist.Size = new System.Drawing.Size(208, 27);
            this.lbproductlist.TabIndex = 4;
            this.lbproductlist.Text = "Danh Sách CTKM";
            // 
            // dgvpromotion
            // 
            this.dgvpromotion.AllowUserToAddRows = false;
            this.dgvpromotion.AllowUserToDeleteRows = false;
            this.dgvpromotion.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpromotion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpromotion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpromotion.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvpromotion.Location = new System.Drawing.Point(23, 38);
            this.dgvpromotion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvpromotion.Name = "dgvpromotion";
            this.dgvpromotion.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpromotion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpromotion.RowHeadersWidth = 62;
            this.dgvpromotion.Size = new System.Drawing.Size(483, 447);
            this.dgvpromotion.TabIndex = 0;
            this.dgvpromotion.SelectionChanged += new System.EventHandler(this.dgvpromotion_SelectionChanged);
            // 
            // formpromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(937, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formpromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Khuyến Mãi";
            this.Load += new System.EventHandler(this.formpromotion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpromotion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbend;
        private System.Windows.Forms.Label lbstart;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lbdiscount;
        private System.Windows.Forms.TextBox txtpromotion;
        private System.Windows.Forms.Label lbpromotion;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtpromotionid;
        private System.Windows.Forms.Label lbpromotionid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbproductlist;
        private System.Windows.Forms.DataGridView dgvpromotion;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.DateTimePicker dtpstart;
    }
}