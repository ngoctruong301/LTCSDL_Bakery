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
    public partial class formpromotion : Form
    {
        private promotionBLL PromotionBLL = new promotionBLL();
        public formpromotion()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            try
            {
                DataTable dt = PromotionBLL.LayDanhSachKhuyenMai();
                dgvpromotion.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            btninsert.Enabled = true;
            btndelete.Enabled = true;
            isEditing = false;
        }

        private void ClearInputs()
        {
            txtpromotionid.Clear();
            txtpromotion.Clear();
            txtdiscount.Clear();
            dtpstart.Value = DateTime.Now;
            dtpend.Value = DateTime.Now;
            dgvpromotion.ClearSelection();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                PromotionBLL.ThemKhuyenMai(
                    txtpromotionid.Text,
                    txtpromotion.Text,
                    int.Parse(txtdiscount.Text),
                    dtpstart.Value,
                    dtpend.Value
                );
                MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvpromotion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chương trình khuyến mãi để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maKhuyenMai = dgvpromotion.SelectedRows[0].Cells["MaKhuyenMai"].Value.ToString();
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa chương trình khuyến mãi {maKhuyenMai}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    PromotionBLL.XoaKhuyenMai(maKhuyenMai);
                    MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadForm();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool isEditing = false;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (dgvpromotion.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một chương trình khuyến mãi để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtpromotionid.Text = dgvpromotion.SelectedRows[0].Cells["MaKhuyenMai"].Value.ToString();
                txtpromotion.Text = dgvpromotion.SelectedRows[0].Cells["TenKhuyenMai"].Value.ToString();
                txtdiscount.Text = dgvpromotion.SelectedRows[0].Cells["SoTienGiam"].Value.ToString();
                dtpstart.Value = Convert.ToDateTime(dgvpromotion.SelectedRows[0].Cells["NgayBatDau"].Value);
                dtpend.Value = Convert.ToDateTime(dgvpromotion.SelectedRows[0].Cells["NgayKetThuc"].Value);

                txtpromotionid.Enabled = false;
                btninsert.Enabled = false;
                btndelete.Enabled = false;
                btnupdate.Enabled = true;
                isEditing = true;
            }
            else
            {
                try
                {
                    PromotionBLL.SuaKhuyenMai(
                        txtpromotionid.Text,
                        txtpromotion.Text,
                        int.Parse(txtdiscount.Text),
                        dtpstart.Value,
                        dtpend.Value
                    );
                    MessageBox.Show("Sửa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void formpromotion_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dgvpromotion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvpromotion.SelectedRows.Count > 0)
            {
                var row = dgvpromotion.SelectedRows[0];
                txtpromotionid.Text = row.Cells["MaKhuyenMai"].Value.ToString();
                txtpromotion.Text = row.Cells["TenKhuyenMai"].Value.ToString();
                txtdiscount.Text = row.Cells["SoTienGiam"].Value.ToString();

                if (DateTime.TryParse(row.Cells["NgayBatDau"].Value?.ToString(), out DateTime startDate))
                    dtpstart.Value = startDate;

                if (DateTime.TryParse(row.Cells["NgayKetThuc"].Value?.ToString(), out DateTime endDate))
                    dtpend.Value = endDate;
            }
        }
    }
}
