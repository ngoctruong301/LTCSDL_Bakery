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
    public partial class formtable : Form
    {
        public formtable()
        {
            InitializeComponent();
        }

        private void formtable_Load(object sender, EventArgs e)
        {
            Loadtable();
        }
        private void Loadtable()
        {
            dgvtable.DataSource = tableBLL.GetAllTables();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            var table = new tableDTO
            {
                TenBan = txttable.Text,
                TrangThai = txttrangthai.Text
            };

            if (tableBLL.InsertTable(table))
            {
                MessageBox.Show("Thêm bàn thành công!");
                Loadtable();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvtable.SelectedRows.Count > 0)
            {
                var row = dgvtable.SelectedRows[0];
                int maBan = Convert.ToInt32(row.Cells["MaBan"].Value);

                var table = new tableDTO
                {
                    MaBan = maBan,
                    TenBan = txttable.Text,
                    TrangThai = txttrangthai.Text
                };

                if (tableBLL.UpdateTable(table))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    Loadtable();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvtable.SelectedRows.Count > 0)
            {
                var row = dgvtable.SelectedRows[0];
                int maBan = Convert.ToInt32(row.Cells["MaBan"].Value);

                if (tableBLL.DeleteTable(maBan))
                {
                    MessageBox.Show("Xóa thành công!");
                    Loadtable();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void ClearInputs()
        {
            txttable.Text = "";
            txttrangthai.Text = "";
            dgvtable.ClearSelection();
        }

        private void dgvtable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvtable.SelectedRows.Count > 0)
            {
                var row = dgvtable.SelectedRows[0];
                txttable.Text = row.Cells["TenBan"].Value.ToString();
                txttrangthai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }
    }
}
