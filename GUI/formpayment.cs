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
using DTO;

namespace GUI
{
    public partial class formpayment : Form
    {
        private paymentBLL PaymentBLL = new paymentBLL();
        private ordersBLL OrdersBLL = new ordersBLL();
        private bool isEditing = false;
        public formpayment()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            btninsert.Enabled = true;
            btndelete.Enabled = true;
            isEditing = false;
        }
        private void ClearInputs()
        {
            txtpaymentid.Clear();
            cboordersid.SelectedIndex = 0;
            txttotal.Clear();
            cbopayment.SelectedIndex = 0;
            dgvpayment.ClearSelection();
        }
        private void LoadForm()
        {
            try
            {
                DataTable dt = PaymentBLL.LayDanhSachThanhToan();
                dgvpayment.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (cboordersid.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã đơn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                PaymentBLL.ThemThanhToan(
                    int.Parse(cboordersid.SelectedItem.ToString()),
                    int.Parse(txttotal.Text),
                    cbopayment.SelectedItem.ToString()
                );
                MessageBox.Show("Thêm thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvpayment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một thanh toán để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maThanhToan = Convert.ToInt32(dgvpayment.SelectedRows[0].Cells["MaThanhToan"].Value);
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thanh toán {maThanhToan}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    PaymentBLL.XoaThanhToan(maThanhToan);
                    MessageBox.Show("Xóa thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvpayment.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một thanh toán để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtpaymentid.Text = dgvpayment.SelectedRows[0].Cells["MaThanhToan"].Value.ToString();
                cboordersid.SelectedItem = dgvpayment.SelectedRows[0].Cells["MaDonHang"].Value.ToString();
                txttotal.Text = dgvpayment.SelectedRows[0].Cells["SoTien"].Value.ToString();
                cbopayment.SelectedItem = dgvpayment.SelectedRows[0].Cells["HinhThuc"].Value.ToString();

                txtpaymentid.Enabled = false;
                btninsert.Enabled = false;
                btndelete.Enabled = false;
                isEditing = true;
            }
            else
            {
                try
                {
                    PaymentBLL.SuaThanhToan(
                        int.Parse(txtpaymentid.Text),
                        int.Parse(cboordersid.SelectedItem.ToString()),
                        int.Parse(txttotal.Text),
                        cbopayment.SelectedItem.ToString()
                    );
                    MessageBox.Show("Sửa thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvpayment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvpayment.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvpayment.SelectedRows[0];
                txtpaymentid.Text = row.Cells["MaThanhToan"].Value?.ToString();
                cboordersid.SelectedItem = row.Cells["MaDonHang"].Value?.ToString();
                txttotal.Text = row.Cells["SoTien"].Value?.ToString();
                cbopayment.SelectedItem = row.Cells["HinhThuc"].Value?.ToString();
            }
        }

        private void formpayment_Load(object sender, EventArgs e)
        {
            LoadForm();
            cbopayment.Items.AddRange(new string[] { "Tiền Mặt", "MoMo", "VNPay" });
            cbopayment.SelectedIndex = 0;
            dgvpayment.AllowUserToAddRows = false;

            DataTable dtDonHang = OrdersBLL.LayDanhSachDonHang();
            foreach (DataRow row in dtDonHang.Rows)
            {
                cboordersid.Items.Add(row["MaDonHang"].ToString());
            }
            if (cboordersid.Items.Count > 0)
                cboordersid.SelectedIndex = 0;
            txtpaymentid.Enabled = false;
        }
    }
}
