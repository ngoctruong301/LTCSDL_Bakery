
namespace GUI
{
    partial class formcategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formcategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.lbcategory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbcategorylist = new System.Windows.Forms.Label();
            this.dgvcategory = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txtcategory);
            this.panel1.Controls.Add(this.lbcategory);
            this.panel1.Location = new System.Drawing.Point(2, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 363);
            this.panel1.TabIndex = 2;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Teal;
            this.btnupdate.Location = new System.Drawing.Point(11, 264);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(144, 71);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Teal;
            this.btnclear.Location = new System.Drawing.Point(203, 264);
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
            this.btndelete.Location = new System.Drawing.Point(203, 153);
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
            this.btninsert.Location = new System.Drawing.Point(11, 153);
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
            // lbcategory
            // 
            this.lbcategory.AutoSize = true;
            this.lbcategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcategory.ForeColor = System.Drawing.Color.Teal;
            this.lbcategory.Location = new System.Drawing.Point(16, 22);
            this.lbcategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbcategory.Name = "lbcategory";
            this.lbcategory.Size = new System.Drawing.Size(174, 27);
            this.lbcategory.TabIndex = 5;
            this.lbcategory.Text = "Tên Danh Mục";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbcategorylist);
            this.panel2.Controls.Add(this.dgvcategory);
            this.panel2.Location = new System.Drawing.Point(389, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 363);
            this.panel2.TabIndex = 3;
            // 
            // lbcategorylist
            // 
            this.lbcategorylist.AutoSize = true;
            this.lbcategorylist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcategorylist.ForeColor = System.Drawing.Color.Teal;
            this.lbcategorylist.Location = new System.Drawing.Point(30, 22);
            this.lbcategorylist.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbcategorylist.Name = "lbcategorylist";
            this.lbcategorylist.Size = new System.Drawing.Size(125, 27);
            this.lbcategorylist.TabIndex = 4;
            this.lbcategorylist.Text = "Danh Mục";
            // 
            // dgvcategory
            // 
            this.dgvcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategory.Location = new System.Drawing.Point(26, 55);
            this.dgvcategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.RowHeadersWidth = 62;
            this.dgvcategory.Size = new System.Drawing.Size(417, 291);
            this.dgvcategory.TabIndex = 0;
            this.dgvcategory.SelectionChanged += new System.EventHandler(this.dgvcategory_SelectionChanged);
            // 
            // formcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(863, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formcategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Sản Phẩm";
            this.Load += new System.EventHandler(this.formcategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label lbcategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbcategorylist;
        private System.Windows.Forms.DataGridView dgvcategory;
    }
}