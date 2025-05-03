
namespace GUI
{
    partial class formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formlogin));
            this.pnlogin = new System.Windows.Forms.Panel();
            this.lbtitle = new System.Windows.Forms.Label();
            this.lbatt = new System.Windows.Forms.Label();
            this.pblogin = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.pnlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlogin
            // 
            this.pnlogin.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlogin.Controls.Add(this.lbtitle);
            this.pnlogin.Controls.Add(this.lbatt);
            this.pnlogin.Controls.Add(this.pblogin);
            this.pnlogin.Location = new System.Drawing.Point(21, 11);
            this.pnlogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlogin.Name = "pnlogin";
            this.pnlogin.Size = new System.Drawing.Size(300, 163);
            this.pnlogin.TabIndex = 6;
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.ForeColor = System.Drawing.Color.Teal;
            this.lbtitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbtitle.Location = new System.Drawing.Point(14, 19);
            this.lbtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(408, 34);
            this.lbtitle.TabIndex = 3;
            this.lbtitle.Text = "Bakery Management System";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbatt
            // 
            this.lbatt.AutoSize = true;
            this.lbatt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbatt.ForeColor = System.Drawing.Color.Red;
            this.lbatt.Location = new System.Drawing.Point(4, 138);
            this.lbatt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbatt.Name = "lbatt";
            this.lbatt.Size = new System.Drawing.Size(318, 21);
            this.lbatt.TabIndex = 1;
            this.lbatt.Text = "Vui Lòng Nhập Thông Tin Người Dùng";
            // 
            // pblogin
            // 
            this.pblogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pblogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pblogin.Image = ((System.Drawing.Image)(resources.GetObject("pblogin.Image")));
            this.pblogin.Location = new System.Drawing.Point(101, 43);
            this.pblogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pblogin.Name = "pblogin";
            this.pblogin.Size = new System.Drawing.Size(100, 85);
            this.pblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogin.TabIndex = 0;
            this.pblogin.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnexit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnexit.Location = new System.Drawing.Point(195, 334);
            this.btnexit.Margin = new System.Windows.Forms.Padding(1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(116, 41);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnlogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnlogin.Location = new System.Drawing.Point(22, 334);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(1);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(116, 41);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(22, 275);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.ShortcutsEnabled = false;
            this.txtpassword.Size = new System.Drawing.Size(290, 24);
            this.txtpassword.TabIndex = 8;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbpassword.ForeColor = System.Drawing.Color.Teal;
            this.lbpassword.Location = new System.Drawing.Point(18, 255);
            this.lbpassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(122, 29);
            this.lbpassword.TabIndex = 12;
            this.lbpassword.Text = "Mật Khẩu";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbuser.ForeColor = System.Drawing.Color.Teal;
            this.lbuser.Location = new System.Drawing.Point(18, 198);
            this.lbuser.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(190, 29);
            this.lbuser.TabIndex = 10;
            this.lbuser.Text = "Tên Đăng Nhập";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtuser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtuser.Location = new System.Drawing.Point(22, 218);
            this.txtuser.Margin = new System.Windows.Forms.Padding(1);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(289, 24);
            this.txtuser.TabIndex = 7;
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(334, 408);
            this.Controls.Add(this.pnlogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbuser);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formlogin_FormClosing);
            this.pnlogin.ResumeLayout(false);
            this.pnlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlogin;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label lbatt;
        private System.Windows.Forms.PictureBox pblogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.TextBox txtuser;
    }
}