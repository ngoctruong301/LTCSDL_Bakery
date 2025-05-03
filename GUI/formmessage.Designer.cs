namespace GUI
{
    partial class formmessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formmessage));
            this.btnsend = new System.Windows.Forms.Button();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.pnmessage = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnsend.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsend.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.Teal;
            this.btnsend.Location = new System.Drawing.Point(291, 277);
            this.btnsend.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(105, 62);
            this.btnsend.TabIndex = 13;
            this.btnsend.Text = "Gửi";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtmessage
            // 
            this.txtmessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmessage.Location = new System.Drawing.Point(12, 277);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(252, 62);
            this.txtmessage.TabIndex = 14;
            this.txtmessage.Text = "Nhập tin nhắn";
            // 
            // pnmessage
            // 
            this.pnmessage.AutoScroll = true;
            this.pnmessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnmessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnmessage.Location = new System.Drawing.Point(0, 0);
            this.pnmessage.Name = "pnmessage";
            this.pnmessage.Size = new System.Drawing.Size(409, 272);
            this.pnmessage.TabIndex = 12;
            // 
            // formmessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 351);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.pnmessage);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formmessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhắn Tin ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.FlowLayoutPanel pnmessage;
    }
}