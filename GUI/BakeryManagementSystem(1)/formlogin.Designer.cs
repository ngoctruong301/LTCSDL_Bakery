namespace BakeryManagementSystem_1_
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
            this.lbuser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pnlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlogin
            // 
            this.pnlogin.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlogin.Controls.Add(this.lbtitle);
            this.pnlogin.Controls.Add(this.lbatt);
            this.pnlogin.Controls.Add(this.pblogin);
            this.pnlogin.Location = new System.Drawing.Point(0, 0);
            this.pnlogin.Name = "pnlogin";
            this.pnlogin.Size = new System.Drawing.Size(300, 181);
            this.pnlogin.TabIndex = 0;
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.ForeColor = System.Drawing.Color.Teal;
            this.lbtitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbtitle.Location = new System.Drawing.Point(13, 21);
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
            this.lbatt.Location = new System.Drawing.Point(3, 154);
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
            this.pblogin.Location = new System.Drawing.Point(102, 56);
            this.pblogin.Name = "pblogin";
            this.pblogin.Size = new System.Drawing.Size(100, 95);
            this.pblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogin.TabIndex = 0;
            this.pblogin.TabStop = false;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbuser.Location = new System.Drawing.Point(11, 201);
            this.lbuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(190, 29);
            this.lbuser.TabIndex = 3;
            this.lbuser.Text = "Tên Đăng Nhập";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtuser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtuser.Location = new System.Drawing.Point(15, 222);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(267, 27);
            this.txtuser.TabIndex = 1;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbpassword.Location = new System.Drawing.Point(13, 276);
            this.lbpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(122, 29);
            this.lbpassword.TabIndex = 5;
            this.lbpassword.Text = "Mật Khẩu";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(15, 297);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.ShortcutsEnabled = false;
            this.txtpassword.Size = new System.Drawing.Size(267, 27);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnlogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnlogin.Location = new System.Drawing.Point(15, 349);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(115, 44);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnexit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnexit.Location = new System.Drawing.Point(167, 349);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(115, 44);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(300, 414);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.pnlogin);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakery Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formlogin_FormClosing);
            this.pnlogin.ResumeLayout(false);
            this.pnlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlogin;
        private System.Windows.Forms.PictureBox pblogin;
        private System.Windows.Forms.Label lbatt;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbtitle;
    }
}

