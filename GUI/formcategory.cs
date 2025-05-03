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
    public partial class formcategory : Form
    {
        public formcategory()
        {
            InitializeComponent();
        }

        private void formcategory_Load(object sender, EventArgs e)
        {
            LoadCategory(); 
        }
        private void LoadCategory()
        {
            try
            {
                var categories = categoryBLL.GetAllCategories();
                dgvcategory.DataSource = categories; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh mục: {ex.Message}");
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvcategory.SelectedRows.Count > 0)
            {
                var selectedRow = dgvcategory.SelectedRows[0];
                int categoryId = Convert.ToInt32(selectedRow.Cells["MaDanhMuc"].Value);
                bool success = categoryBLL.DeleteCategory(categoryId);
                if (success)
                {
                    MessageBox.Show("Danh mục đã được xóa!");
                    LoadCategory();  
                    ResetFormCategory(); 
                }
                else
                {
                    MessageBox.Show("Xóa danh mục không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa.");
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string categoryName = txtcategory.Text;
            categoryDTO newCategory = new categoryDTO
            {
                TenDanhMuc = categoryName
            };
            bool success = categoryBLL.InsertCategory(newCategory);
            if (success)
            {
                MessageBox.Show("Danh mục đã được thêm thành công!");
                LoadCategory();  
            }
            else
            {
                MessageBox.Show("Thêm danh mục không thành công!");
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (dgvcategory.SelectedRows.Count > 0)
            {
                var selectedRow = dgvcategory.SelectedRows[0];
                int categoryId = Convert.ToInt32(selectedRow.Cells["MaDanhMuc"].Value); 

                categoryDTO updatedCategory = new categoryDTO
                {
                    MaDanhMuc = categoryId, 
                    TenDanhMuc = txtcategory.Text  
                };

                bool success = categoryBLL.UpdateCategory(updatedCategory);
                if (success)
                {
                    MessageBox.Show("Danh mục đã được cập nhật thành công!");
                    LoadCategory(); 
                }
                else
                {
                    MessageBox.Show("Cập nhật danh mục thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục cần cập nhật.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ResetFormCategory();
        }
        private void ResetFormCategory()
        {
            txtcategory.Text = "";  
            dgvcategory.ClearSelection();
        }

        private void dgvcategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvcategory.SelectedRows.Count > 0)
            {
                var selectedRow = dgvcategory.SelectedRows[0];
                txtcategory.Text = selectedRow.Cells["TenDanhMuc"].Value.ToString();
            }
        }
    }
}
