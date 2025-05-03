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
    public partial class formordersitem : Form
    {
        public formordersitem()
        {
            InitializeComponent();
        }

        private void formordersitem_Load(object sender, EventArgs e)
        {
            LoadOrdersitem();
        }
        private void LoadOrdersitem()
        {
            try
            {
                var ordersitem = ordersitemBLL.GetAllOrders();
                dgvordersitem.DataSource = ordersitem;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load đơn hàng: {ex.Message}");
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            int maDonHang;
            int soLuong;

            if (int.TryParse(txtordersid.Text, out maDonHang) && int.TryParse(txtqty.Text, out soLuong))
            {
                ordersitemDTO insertordersitem = new ordersitemDTO
                {
                    MaDonHang = maDonHang,
                    MaSanPham = txtproductid.Text,
                    SoLuong = soLuong
                };

                bool success = ordersitemBLL.InsertOrdersitem(insertordersitem);
                if (success)
                {
                    MessageBox.Show("Thêm đơn hàng thành công!");
                    LoadOrdersitem();
                    ResetFormOrdersitem();
                }
                else
                {
                    MessageBox.Show("Thêm đơn hàng không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho Mã Đơn Hàng và Số Lượng!");
            }
        }

        private void ResetFormOrdersitem()
        {
            txtordersid.Text = "";
            txtproductid.Text = "";
            txtqty.Text = "";
            dgvordersitem.ClearSelection();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvordersitem.SelectedRows.Count > 0)
            {
                var selectedRow = dgvordersitem.SelectedRows[0];
                int maDonHang = Convert.ToInt32(selectedRow.Cells["MaDonHang"].Value);

                bool success = ordersitemBLL.DeleteOrdersitem(maDonHang);
                if (success)
                {
                    MessageBox.Show("Xoá đơn hàng thành công!");
                    LoadOrdersitem();
                    ResetFormOrdersitem();
                }
                else
                {
                    MessageBox.Show("Xóa đơn hàng không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvordersitem.SelectedRows.Count > 0)
            {
                var selectedRow = dgvordersitem.SelectedRows[0];

                int maDonHang;
                int soLuong;

                if (int.TryParse(txtordersid.Text, out maDonHang) && int.TryParse(txtqty.Text, out soLuong))
                {
                    ordersitemDTO updateordersitem = new ordersitemDTO
                    {
                        MaDonHang = maDonHang,
                        MaSanPham = txtproductid.Text,
                        SoLuong = soLuong
                    };

                    bool success = ordersitemBLL.UpdateOrdersitem(updateordersitem);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật đơn hàng thành công!");
                        LoadOrdersitem();
                        ResetFormOrdersitem();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật đơn hàng không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho Mã Đơn Hàng và Số Lượng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần cập nhật.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ResetFormOrdersitem();
        }

        private void dgvordersitem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvordersitem.SelectedRows.Count > 0)
            {
                var selectedRow = dgvordersitem.SelectedRows[0];
                txtordersid.Text = selectedRow.Cells["MaDonHang"].Value.ToString();
                txtproductid.Text = selectedRow.Cells["MaSanPham"].Value.ToString();
                txtqty.Text = selectedRow.Cells["SoLuong"].Value.ToString();
            }
        }
    }
}
