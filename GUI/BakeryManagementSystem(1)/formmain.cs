using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryManagementSystem_1_
{
    public partial class formmain : Form
    {
        public formmain()
        {
            InitializeComponent();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear(); 
            formdashboard f = new formdashboard();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panel_Main.Controls.Add(f);
            f.Show();
        }
    }
}
