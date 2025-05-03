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
    public partial class formproduct : Form
    {
        public formproduct()
        {
            InitializeComponent();
        }

        private void formproduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            try
            {
                var products = productBLL.GetAllProducts();
                dgvproductlist.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load sản phẩm: {ex.Message}");
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            productDTO product = new productDTO
            {
                MaSanPham = txtuser.Text,
                TenSanPham = txtproduct.Text,
                GiaTien = int.Parse(txtprice.Text),
                MaNCC = txtsupplierid.Text,
                MaDanhMuc = int.Parse(txtcategoryid.Text)
            };

            if (productBLL.AddProduct(product))
            {
                MessageBox.Show("Thêm thành công!");
                LoadProducts();
                ResetFormProduct();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvproductlist.SelectedRows.Count > 0)
            {
                var selectedRow = dgvproductlist.SelectedRows[0];

                productDTO updatedProduct = new productDTO
                {
                    MaSanPham = txtuser.Text,
                    TenSanPham = txtproduct.Text,
                    GiaTien = int.TryParse(txtprice.Text, out int giaTien) ? giaTien : 0,
                    MaNCC = txtsupplierid.Text,
                    MaDanhMuc = int.TryParse(txtcategoryid.Text, out int maDanhMuc) ? maDanhMuc : 0
                };

                bool success = productBLL.UpdateProduct(updatedProduct);
                if (success)
                {
                    MessageBox.Show("Sản phẩm đã được cập nhật thành công!");
                    LoadProducts();
                    ResetFormProduct();
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật.");
            }

        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvproductlist.SelectedRows.Count > 0)
            {
                var selectedRow = dgvproductlist.SelectedRows[0];
                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();

                bool success = productBLL.DeleteProduct(maSanPham);
                if (success)
                {
                    MessageBox.Show("Sản phẩm đã được xóa thành công!");
                    LoadProducts();
                    ResetFormProduct();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ResetFormProduct();
        }
        private void ResetFormProduct()
        {
            txtuser.Text = "";
            txtproduct.Text = "";
            txtprice.Text = "";
            txtsupplierid.Text = "";
            txtcategoryid.Text = "";
            dgvproductlist.ClearSelection();
        }
        private void dgvproductlist_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvproductlist.SelectedRows.Count > 0)
            {
                var selectedRow = dgvproductlist.SelectedRows[0];
                txtuser.Text = selectedRow.Cells["MaSanPham"].Value.ToString();
                txtproduct.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                txtprice.Text = selectedRow.Cells["GiaTien"].Value.ToString();
                txtsupplierid.Text = selectedRow.Cells["MaNCC"].Value.ToString();
                txtcategoryid.Text = selectedRow.Cells["MaDanhMuc"].Value.ToString();
            }
        }
    }
}
