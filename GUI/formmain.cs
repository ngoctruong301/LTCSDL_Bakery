using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formmain : Form
    {
        private string currentUserRole;
        public formmain(string LoaiTaiKhoan)
        {
            InitializeComponent();
            currentUserRole = LoaiTaiKhoan;
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            formuser frmUser = new formuser(currentUserRole);
            frmUser.ShowDialog();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            formcategory frmcategory = new formcategory();
            frmcategory.ShowDialog();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            formproduct frmproduct = new formproduct();
            frmproduct.ShowDialog();
        }

        private void btntable_Click(object sender, EventArgs e)
        {
            formtable frmtable = new formtable();
            frmtable.ShowDialog();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            formsupplier frmsupplier = new formsupplier();
            frmsupplier.ShowDialog();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            formorders frmorders = new formorders();
            frmorders.ShowDialog();
        }

        private void btnordesitem_Click(object sender, EventArgs e)
        {
            formordersitem frmordersitem = new formordersitem();
            frmordersitem.ShowDialog();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            formpayment frmpayment = new formpayment();
            frmpayment.ShowDialog();
        }

        private void btnpromotion_Click(object sender, EventArgs e)
        {
            formpromotion frmpromotion = new formpromotion();
            frmpromotion.ShowDialog();
        }

        private void btnshipping_Click(object sender, EventArgs e)
        {
            formshipping frmshipping = new formshipping();
            frmshipping.ShowDialog();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            formreport frmreport = new formreport();
            frmreport.ShowDialog();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            formmessage frmmessage = new formmessage();
            frmmessage.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
