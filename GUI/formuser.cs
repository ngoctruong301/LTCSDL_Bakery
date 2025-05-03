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
    public partial class formuser : Form
    {
        private string currentUserRole;
        public formuser(string LoaiTaiKhoan)
        {
            InitializeComponent();
            currentUserRole = LoaiTaiKhoan;
        }

        private void formuser_Load(object sender, EventArgs e)
        {
            LoadUsers();
            ApplyPermission();
        }
        private void LoadUsers()
        {
            var users = userBLL.GetAllUsers();
            dgvuser.DataSource = users;
        }
        private void ApplyPermission()
        {
            string role = currentUserRole.Trim().ToLower();

            if (!role.Contains("quản lý") && !role.Contains("admin"))
            {
                btninsert.Enabled = false;
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                txtcategory.Enabled = false;
                txtproductid.Enabled = false;
                txtqty.Enabled = false;
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            Resetformuser();
        }
        private void Resetformuser()
        {
            txtcategory.Text = "";
            txtproductid.Text = "";
            txtqty.Text = "";
            dgvuser.ClearSelection();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtcategory.Text;
            var existingUser = userBLL.GetAllUsers().FirstOrDefault(u => u.TaiKhoan == taiKhoan);

            if (existingUser != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.");
                return;
            }
            userDTO newUser = new userDTO
            {
                TaiKhoan = txtcategory.Text,
                MatKhau = txtproductid.Text,
                LoaiTaiKhoan = txtqty.Text,
            };

            bool success = userBLL.InsertUser(newUser);
            if (success)
            {
                MessageBox.Show("Thêm người dùng thành công!");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Thêm người dùng thất bại !");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            userDTO updatedUser = new userDTO
            {
                TaiKhoan = txtcategory.Text,
                MatKhau = txtproductid.Text,
                LoaiTaiKhoan = txtqty.Text,
            };

            bool success = userBLL.UpdateUser(updatedUser);
            if (success)
            {
                MessageBox.Show("Cập nhật người dùng thành công!");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Cập nhật người dùng thất bại!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtcategory.Text;

            bool success = userBLL.DeleteUser(taiKhoan);
            if (success)
            {
                MessageBox.Show("Xóa người dùng thành công!");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Xóa người dùng thất bại!");
            }
        }

        private void dgvuser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvuser.SelectedRows.Count > 0) 
            {
                var selectedRow = dgvuser.SelectedRows[0];
                txtcategory.Text = selectedRow.Cells["TaiKhoan"].Value.ToString();
                txtproductid.Text = selectedRow.Cells["MatKhau"].Value.ToString();
                txtqty.Text = selectedRow.Cells["LoaiTaiKhoan"].Value.ToString();
            }
        }
    }
}
