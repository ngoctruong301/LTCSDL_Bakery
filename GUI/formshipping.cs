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
    public partial class formshipping : Form
    {
        private shippingBLL ShippingBLL = new shippingBLL();
        private ordersBLL OrdersBLL = new ordersBLL();
        private bool isEditing = false;
        public formshipping()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            btninsert.Enabled = true;
            btndelete.Enabled = true;
            isEditing = false;
        }

        private void formshipping_Load(object sender, EventArgs e)
        {
            Loadshipping();

            cbostatus.Items.AddRange(new string[] { "Đang giao", "Đã giao", "Hủy" });
            cbostatus.SelectedIndex = 0;

            DataTable dtDonHang = OrdersBLL.LayDanhSachDonHang();
            foreach (DataRow row in dtDonHang.Rows)
            {
                cbocategory.Items.Add(row["MaDonHang"].ToString());
            }
            if (cbocategory.Items.Count > 0)
                cbocategory.SelectedIndex = 0;

            dgvshipping.AllowUserToAddRows = false;
        }
        private void LoadComboBoxData()
        {

            cbostatus.Items.AddRange(new string[] { "Đã giao", "Đang xử lý", "Đã hủy" });
            cbostatus.SelectedIndex = 0;

            DataTable dtOrders = OrdersBLL.LayDanhSachDonHang();
            foreach (DataRow row in dtOrders.Rows)
            {
                cbocategory.Items.Add(row["MaDonHang"].ToString());
            }

            if (cbocategory.Items.Count > 0)
                cbocategory.SelectedIndex = 0;
        }
        private void Loadshipping()
        {
            try
            {
                dgvshipping.DataSource = ShippingBLL.LayDanhSachGiaoHang();
                dgvshipping.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            cbocategory.SelectedIndex = 0;
            cbostatus.SelectedIndex = 0;
            txtaddress.Clear();
            txtsdt.Clear();
            dgvshipping.ClearSelection();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (cbocategory.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã đơn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ShippingBLL.ThemGiaoHang(
                    int.Parse(cbocategory.SelectedItem.ToString()),
                    txtaddress.Text,
                    int.Parse(txtsdt.Text),
                    cbostatus.SelectedItem.ToString()
                );
                MessageBox.Show("Thêm giao hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadshipping();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (dgvshipping.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn bản ghi để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cbocategory.SelectedItem = dgvshipping.SelectedRows[0].Cells["MaDonHang"].Value.ToString();
                txtaddress.Text = dgvshipping.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                txtsdt.Text = dgvshipping.SelectedRows[0].Cells["SDT"].Value.ToString();
                cbostatus.SelectedItem = dgvshipping.SelectedRows[0].Cells["TrangThai"].Value.ToString();

                btninsert.Enabled = false;
                btndelete.Enabled = false;
                isEditing = true;
            }
            else
            {
                try
                {
                    int maGiaoHang = Convert.ToInt32(dgvshipping.SelectedRows[0].Cells["MaGiaoHang"].Value);
                    ShippingBLL.SuaGiaoHang(
                        maGiaoHang,
                        int.Parse(cbocategory.SelectedItem.ToString()),
                        txtaddress.Text,
                        int.Parse(txtsdt.Text),
                        cbostatus.SelectedItem.ToString()
                    );
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loadshipping();
                    ClearInputs();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvshipping.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maGiaoHang = Convert.ToInt32(dgvshipping.SelectedRows[0].Cells["MaGiaoHang"].Value);
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa giao hàng {maGiaoHang}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ShippingBLL.XoaGiaoHang(maGiaoHang);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loadshipping();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ResetForm();
        }

        private void dgvshipping_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvshipping.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvshipping.SelectedRows[0];
                cbocategory.SelectedItem = row.Cells["MaDonHang"].Value?.ToString();
                txtaddress.Text = row.Cells["DiaChi"].Value?.ToString();
                txtsdt.Text = row.Cells["SDT"].Value?.ToString();
                cbostatus.SelectedItem = row.Cells["TrangThai"].Value?.ToString();
            }
        }
    }
}
