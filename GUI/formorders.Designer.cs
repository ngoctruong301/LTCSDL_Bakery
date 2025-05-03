namespace GUI
{
    partial class formorders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formorders));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lborders = new System.Windows.Forms.Label();
            this.dgvorders = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttableid = new System.Windows.Forms.TextBox();
            this.lbtableid = new System.Windows.Forms.Label();
            this.cbopromotionid = new System.Windows.Forms.ComboBox();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.lbpromotionid = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txttime = new System.Windows.Forms.TextBox();
            this.lbtime = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtordersid = new System.Windows.Forms.TextBox();
            this.lbordersid = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lborders);
            this.panel2.Controls.Add(this.dgvorders);
            this.panel2.Location = new System.Drawing.Point(401, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 514);
            this.panel2.TabIndex = 12;
            // 
            // lborders
            // 
            this.lborders.AutoSize = true;
            this.lborders.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborders.ForeColor = System.Drawing.Color.Teal;
            this.lborders.Location = new System.Drawing.Point(20, 18);
            this.lborders.Name = "lborders";
            this.lborders.Size = new System.Drawing.Size(208, 27);
            this.lborders.TabIndex = 4;
            this.lborders.Text = "Danh Sách CTKM";
            // 
            // dgvorders
            // 
            this.dgvorders.AllowUserToAddRows = false;
            this.dgvorders.AllowUserToDeleteRows = false;
            this.dgvorders.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvorders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvorders.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvorders.Location = new System.Drawing.Point(23, 38);
            this.dgvorders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvorders.Name = "dgvorders";
            this.dgvorders.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvorders.RowHeadersWidth = 62;
            this.dgvorders.Size = new System.Drawing.Size(483, 447);
            this.dgvorders.TabIndex = 0;
            this.dgvorders.SelectionChanged += new System.EventHandler(this.dgvorders_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txttableid);
            this.panel1.Controls.Add(this.lbtableid);
            this.panel1.Controls.Add(this.cbopromotionid);
            this.panel1.Controls.Add(this.cbostatus);
            this.panel1.Controls.Add(this.lbpromotionid);
            this.panel1.Controls.Add(this.lbstatus);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txttime);
            this.panel1.Controls.Add(this.lbtime);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txtordersid);
            this.panel1.Controls.Add(this.lbordersid);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 514);
            this.panel1.TabIndex = 13;
            // 
            // txttableid
            // 
            this.txttableid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttableid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttableid.Location = new System.Drawing.Point(13, 141);
            this.txttableid.Margin = new System.Windows.Forms.Padding(1);
            this.txttableid.Multiline = true;
            this.txttableid.Name = "txttableid";
            this.txttableid.Size = new System.Drawing.Size(324, 31);
            this.txttableid.TabIndex = 23;
            // 
            // lbtableid
            // 
            this.lbtableid.AutoSize = true;
            this.lbtableid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtableid.ForeColor = System.Drawing.Color.Teal;
            this.lbtableid.Location = new System.Drawing.Point(17, 122);
            this.lbtableid.Name = "lbtableid";
            this.lbtableid.Size = new System.Drawing.Size(95, 27);
            this.lbtableid.TabIndex = 24;
            this.lbtableid.Text = "Mã Bàn";
            // 
            // cbopromotionid
            // 
            this.cbopromotionid.FormattingEnabled = true;
            this.cbopromotionid.Location = new System.Drawing.Point(13, 251);
            this.cbopromotionid.Name = "cbopromotionid";
            this.cbopromotionid.Size = new System.Drawing.Size(324, 27);
            this.cbopromotionid.TabIndex = 22;
            // 
            // cbostatus
            // 
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Location = new System.Drawing.Point(13, 199);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(324, 27);
            this.cbostatus.TabIndex = 21;
            // 
            // lbpromotionid
            // 
            this.lbpromotionid.AutoSize = true;
            this.lbpromotionid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpromotionid.ForeColor = System.Drawing.Color.Teal;
            this.lbpromotionid.Location = new System.Drawing.Point(17, 230);
            this.lbpromotionid.Name = "lbpromotionid";
            this.lbpromotionid.Size = new System.Drawing.Size(181, 27);
            this.lbpromotionid.TabIndex = 18;
            this.lbpromotionid.Text = "Mã Khuyến Mãi";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.ForeColor = System.Drawing.Color.Teal;
            this.lbstatus.Location = new System.Drawing.Point(17, 178);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(133, 27);
            this.lbstatus.TabIndex = 16;
            this.lbstatus.Text = "Trạng Thái";
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
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttime.Location = new System.Drawing.Point(13, 89);
            this.txttime.Margin = new System.Windows.Forms.Padding(1);
            this.txttime.Multiline = true;
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(324, 32);
            this.txttime.TabIndex = 12;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.ForeColor = System.Drawing.Color.Teal;
            this.lbtime.Location = new System.Drawing.Point(17, 69);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(124, 27);
            this.lbtime.TabIndex = 13;
            this.lbtime.Text = "Thời Gian";
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
            // txtordersid
            // 
            this.txtordersid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtordersid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtordersid.Location = new System.Drawing.Point(13, 37);
            this.txtordersid.Margin = new System.Windows.Forms.Padding(1);
            this.txtordersid.Multiline = true;
            this.txtordersid.Name = "txtordersid";
            this.txtordersid.Size = new System.Drawing.Size(324, 31);
            this.txtordersid.TabIndex = 5;
            // 
            // lbordersid
            // 
            this.lbordersid.AutoSize = true;
            this.lbordersid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbordersid.ForeColor = System.Drawing.Color.Teal;
            this.lbordersid.Location = new System.Drawing.Point(17, 18);
            this.lbordersid.Name = "lbordersid";
            this.lbordersid.Size = new System.Drawing.Size(163, 27);
            this.lbordersid.TabIndex = 5;
            this.lbordersid.Text = "Mã Đơn Hàng";
            // 
            // formorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formorders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Hàng";
            this.Load += new System.EventHandler(this.formorders_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lborders;
        private System.Windows.Forms.DataGridView dgvorders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbpromotionid;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtordersid;
        private System.Windows.Forms.Label lbordersid;
        private System.Windows.Forms.ComboBox cbostatus;
        private System.Windows.Forms.ComboBox cbopromotionid;
        private System.Windows.Forms.TextBox txttableid;
        private System.Windows.Forms.Label lbtableid;
    }
}