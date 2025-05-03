using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class formlogin : Form
    {
        userDTO user = new userDTO();
        public formlogin()
        {
            InitializeComponent();
        }

        private void formlogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            user.TaiKhoan = txtuser.Text;
            user.MatKhau = txtpassword.Text;
            string result = userBLL.CheckLogic(user);
            if (result == "requeid_taikhoan")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "requeid_MatKhau")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "invalid")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string loaiTaiKhoan = userBLL.GetUserRole(user.TaiKhoan);
                this.Hide();
                formmain frmMain = new formmain(loaiTaiKhoan); 
                frmMain.ShowDialog();
                this.Show();
            }
        }
    }
}
