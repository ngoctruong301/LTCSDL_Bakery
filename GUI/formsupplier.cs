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
    public partial class formsupplier : Form
    {
        public formsupplier()
        {
            InitializeComponent();
        }

        private void formsupplier_Load(object sender, EventArgs e)
        {
            Loadsupplier();
        }
        private void Loadsupplier()
        {
            dgvsupplier.DataSource = supplierBLL.LayDanhSachNhaCungCap();
            dgvsupplier.ClearSelection();
        }
        private void ClearInputs()
        {
            txtuser.Clear();
            namesupplier.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtsdt.Text.Trim(), out int sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            supplierDTO supplier = new supplierDTO
            {
                MaNCC = txtuser.Text.Trim(),
                TenNCC = namesupplier.Text.Trim(),
                DiaChi = txtdiachi.Text.Trim(),
                SDT = sdt
            };

            bool success = supplierBLL.ThemNhaCungCap(supplier);
            if (success)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                Loadsupplier();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtsdt.Text.Trim(), out int sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            supplierDTO supplier = new supplierDTO
            {
                MaNCC = txtuser.Text.Trim(),
                TenNCC = namesupplier.Text.Trim(),
                DiaChi = txtdiachi.Text.Trim(),
                SDT = sdt
            };

            bool success = supplierBLL.SuaNhaCungCap(supplier);
            if (success)
            {
                MessageBox.Show("Cập nhật thành công!");
                Loadsupplier();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvsupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!");
                return;
            }

            string maNCC = dgvsupplier.SelectedRows[0].Cells["MaNCC"].Value.ToString();
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhà cung cấp {maNCC}?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool success = supplierBLL.XoaNhaCungCap(maNCC);
                if (success)
                {
                    MessageBox.Show("Xóa thành công!");
                    Loadsupplier();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvsupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsupplier.SelectedRows.Count > 0)
            {
                var row = dgvsupplier.SelectedRows[0];
                txtuser.Text = row.Cells["MaNCC"].Value?.ToString();
                namesupplier.Text = row.Cells["TenNCC"].Value?.ToString();
                txtdiachi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtsdt.Text = row.Cells["SDT"].Value?.ToString();
            }
        }
    }
}
