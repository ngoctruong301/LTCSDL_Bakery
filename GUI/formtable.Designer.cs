namespace GUI
{
    partial class formtable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formtable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txttable = new System.Windows.Forms.TextBox();
            this.lbtable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbtablelist = new System.Windows.Forms.Label();
            this.dgvtable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txttrangthai);
            this.panel1.Controls.Add(this.lbstatus);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txttable);
            this.panel1.Controls.Add(this.lbtable);
            this.panel1.Location = new System.Drawing.Point(8, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 384);
            this.panel1.TabIndex = 4;
            // 
            // txttrangthai
            // 
            this.txttrangthai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttrangthai.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttrangthai.Location = new System.Drawing.Point(11, 110);
            this.txttrangthai.Multiline = true;
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(324, 38);
            this.txttrangthai.TabIndex = 10;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.ForeColor = System.Drawing.Color.Teal;
            this.lbstatus.Location = new System.Drawing.Point(16, 89);
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
            this.btnupdate.Location = new System.Drawing.Point(9, 293);
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
            this.btnclear.Location = new System.Drawing.Point(201, 293);
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
            this.btndelete.Location = new System.Drawing.Point(201, 182);
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
            this.btninsert.Location = new System.Drawing.Point(9, 182);
            this.btninsert.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(144, 71);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Thêm";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txttable
            // 
            this.txttable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttable.Location = new System.Drawing.Point(11, 43);
            this.txttable.Multiline = true;
            this.txttable.Name = "txttable";
            this.txttable.Size = new System.Drawing.Size(324, 32);
            this.txttable.TabIndex = 5;
            // 
            // lbtable
            // 
            this.lbtable.AutoSize = true;
            this.lbtable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtable.ForeColor = System.Drawing.Color.Teal;
            this.lbtable.Location = new System.Drawing.Point(16, 22);
            this.lbtable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbtable.Name = "lbtable";
            this.lbtable.Size = new System.Drawing.Size(106, 27);
            this.lbtable.TabIndex = 5;
            this.lbtable.Text = "Tên Bàn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbtablelist);
            this.panel2.Controls.Add(this.dgvtable);
            this.panel2.Location = new System.Drawing.Point(395, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 384);
            this.panel2.TabIndex = 5;
            // 
            // lbtablelist
            // 
            this.lbtablelist.AutoSize = true;
            this.lbtablelist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtablelist.ForeColor = System.Drawing.Color.Teal;
            this.lbtablelist.Location = new System.Drawing.Point(23, 22);
            this.lbtablelist.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbtablelist.Name = "lbtablelist";
            this.lbtablelist.Size = new System.Drawing.Size(185, 27);
            this.lbtablelist.TabIndex = 4;
            this.lbtablelist.Text = "Danh Sách Bàn";
            // 
            // dgvtable
            // 
            this.dgvtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtable.Location = new System.Drawing.Point(26, 55);
            this.dgvtable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvtable.Name = "dgvtable";
            this.dgvtable.RowHeadersWidth = 62;
            this.dgvtable.Size = new System.Drawing.Size(417, 309);
            this.dgvtable.TabIndex = 0;
            this.dgvtable.SelectionChanged += new System.EventHandler(this.dgvtable_SelectionChanged);
            // 
            // formtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formtable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bàn";
            this.Load += new System.EventHandler(this.formtable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txttable;
        private System.Windows.Forms.Label lbtable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbtablelist;
        private System.Windows.Forms.DataGridView dgvtable;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.Label lbstatus;
    }
}