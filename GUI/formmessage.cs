using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class formmessage : Form
    {
        messageBLL MessageBLL = new messageBLL();
        public formmessage()
        {
            InitializeComponent();
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            string userInput = txtmessage.Text.Trim();
            if (string.IsNullOrEmpty(userInput)) return;
            AddMessage("Bạn", userInput, true);
            string botReply = messageBLL.GetResponse(userInput);
            AddMessage("Bot", botReply, false);
            txtmessage.Clear(); 
            txtmessage.Focus(); 
        }
        private void AddMessage(string sender, string message, bool isUser)
        {
            Panel messagePanel = new Panel();
            messagePanel.AutoSize = true; 
            messagePanel.Padding = new Padding(5); 
            messagePanel.Margin = new Padding(5); 

            Label lblMessage = new Label();
            lblMessage.Text = message; 
            lblMessage.AutoSize = true;
            lblMessage.MaximumSize = new Size(250, 0);
            lblMessage.Padding = new Padding(10);
            lblMessage.BackColor = isUser ? Color.LightGreen : Color.LightBlue;

            messagePanel.Dock = isUser ? DockStyle.Right : DockStyle.Left;
            messagePanel.Controls.Add(lblMessage);

            pnmessage.Controls.Add(messagePanel);
            pnmessage.ScrollControlIntoView(messagePanel);
        }
    }
}
