namespace GUI
{
    partial class formreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formreport));
            this.cbreport = new System.Windows.Forms.ComboBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvreport = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbreport
            // 
            this.cbreport.FormattingEnabled = true;
            this.cbreport.Location = new System.Drawing.Point(38, 23);
            this.cbreport.Name = "cbreport";
            this.cbreport.Size = new System.Drawing.Size(215, 32);
            this.cbreport.TabIndex = 0;
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnselect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.ForeColor = System.Drawing.Color.Teal;
            this.btnselect.Location = new System.Drawing.Point(282, 13);
            this.btnselect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(118, 43);
            this.btnselect.TabIndex = 7;
            this.btnselect.Text = "Chọn";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvreport);
            this.panel2.Controls.Add(this.btnselect);
            this.panel2.Controls.Add(this.cbreport);
            this.panel2.Location = new System.Drawing.Point(4, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 363);
            this.panel2.TabIndex = 7;
            // 
            // dgvreport
            // 
            this.dgvreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreport.Location = new System.Drawing.Point(26, 64);
            this.dgvreport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvreport.Name = "dgvreport";
            this.dgvreport.RowHeadersWidth = 62;
            this.dgvreport.Size = new System.Drawing.Size(406, 268);
            this.dgvreport.TabIndex = 0;
            // 
            // formreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 382);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê";
            this.Load += new System.EventHandler(this.formreport_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbreport;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvreport;
    }
}