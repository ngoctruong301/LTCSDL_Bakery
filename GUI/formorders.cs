using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class formorders : Form
    {
        private ordersBLL OrdersBLL = new ordersBLL();
        private promotionBLL PromotionBLL = new promotionBLL();
        private bool isEditing = false;
        public formorders()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            try
            {
                DataTable dt = OrdersBLL.LayDanhSachDonHang();
                dgvorders.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtordersid.Clear();
            txttime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txttableid.Clear();
            cbostatus.SelectedIndex = 0;
            cbopromotionid.SelectedIndex = 0;
        }
        private void ResetForm()
        {
            btninsert.Enabled = true;
            btndelete.Enabled = true;
            isEditing = false;
        }

        private void formorders_Load(object sender, EventArgs e)
        {
            LoadForm();
            cbostatus.Items.AddRange(new string[] { "Đang chuẩn bị", "Hoàn thành", "Hủy" });
            cbostatus.SelectedIndex = 0;
            DataTable dtKhuyenMai = PromotionBLL.LayDanhSachKhuyenMai();
            cbopromotionid.Items.Add("Không áp dụng");
            foreach (DataRow row in dtKhuyenMai.Rows)
            {
                cbopromotionid.Items.Add(row["MaKhuyenMai"].ToString());
            }
            cbopromotionid.SelectedIndex = 0;
            txtordersid.Enabled = false;
            txttime.Enabled = false;
            txttime.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txttableid.Text) || !int.TryParse(txttableid.Text, out int maBan))
                {
                    MessageBox.Show("Mã bàn không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbopromotionid.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn mã khuyến mãi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbostatus.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maKhuyenMai = cbopromotionid.SelectedItem.ToString() == "Không áp dụng" ? null : cbopromotionid.SelectedItem.ToString();
                string trangThai = cbostatus.SelectedItem.ToString();

                OrdersBLL.ThemDonHang(
                    maBan,
                    maKhuyenMai,
                    trangThai
                );
                MessageBox.Show("Thêm đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadForm();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvorders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maDonHang = Convert.ToInt32(dgvorders.SelectedRows[0].Cells["MaDonHang"].Value);
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đơn hàng {maDonHang}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    OrdersBLL.XoaDonHang(maDonHang);
                    MessageBox.Show("Xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadForm();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (dgvorders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một đơn hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtordersid.Text = dgvorders.SelectedRows[0].Cells["MaDonHang"].Value.ToString();
                txttime.Text = Convert.ToDateTime(dgvorders.SelectedRows[0].Cells["ThoiGian"].Value).ToString("yyyy-MM-dd");
                txttableid.Text = dgvorders.SelectedRows[0].Cells["MaBan"].Value.ToString();
                cbostatus.SelectedItem = dgvorders.SelectedRows[0].Cells["TrangThai"].Value.ToString();
                var maKhuyenMai = dgvorders.SelectedRows[0].Cells["MaKhuyenMai"].Value;
                cbopromotionid.SelectedItem = maKhuyenMai == DBNull.Value ? "Không áp dụng" : maKhuyenMai.ToString();

                txtordersid.Enabled = false;
                btninsert.Enabled = false;
                btndelete.Enabled = false;
                isEditing = true;
            }
            else
            {
                try
                {
                    string maKhuyenMai = cbopromotionid.SelectedItem.ToString() == "Không áp dụng" ? null : cbopromotionid.SelectedItem.ToString();
                    OrdersBLL.SuaDonHang(
                        int.Parse(txtordersid.Text),
                        int.Parse(txttableid.Text),
                        cbostatus.SelectedItem.ToString(),
                        maKhuyenMai
                    );
                    MessageBox.Show("Sửa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadForm();
                    ClearInputs();
                    ResetForm();
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

        private void dgvorders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvorders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvorders.SelectedRows[0];

                txtordersid.Text = row.Cells["MaDonHang"].Value?.ToString();
                txttime.Text = row.Cells["ThoiGian"].Value?.ToString();
                txttableid.Text = row.Cells["MaBan"].Value?.ToString();
                cbostatus.Text = row.Cells["TrangThai"].Value?.ToString();
                cbopromotionid.Text = row.Cells["MaKhuyenMai"].Value?.ToString();
            }
        }
    }
}
