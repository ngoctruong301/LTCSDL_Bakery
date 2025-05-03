using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class formreport : Form
    {
        reportBLL ReportBLL = new reportBLL();
        public formreport()
        {
            InitializeComponent();
        }
        private void ShowDoanhThu()
        {
            var dt = reportBLL.GetDoanhThu(); ;  
            dgvreport.DataSource = dt;  
        }
        private void ShowSoLuongDon()
        {
            DataTable dt = reportBLL.GetSoLuongDon();
            dgvreport.DataSource = dt;
        }
        private void ShowDoanhThuTheoHinhThuc()
        {
            DataTable dt = reportBLL.GetDoanhThuTheoHinhThuc();
            dgvreport.DataSource = dt;
        }
        private void formreport_Load(object sender, EventArgs e)
        {
            cbreport.Items.Add("Doanh Thu");
            cbreport.Items.Add("Số Lượng Đơn");
            cbreport.Items.Add("Doanh Thu Theo Hình Thức Thanh Toán");
            cbreport.SelectedIndex = 0; 
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            string selectedReport = cbreport.SelectedItem?.ToString(); 
            if (string.IsNullOrEmpty(selectedReport))
            {
                MessageBox.Show("Vui lòng chọn một loại báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (selectedReport)
            {
                case "Doanh Thu":
                    ShowDoanhThu();
                    break;
                case "Số Lượng Đơn":
                    ShowSoLuongDon();
                    break;
                case "Doanh Thu Theo Hình Thức Thanh Toán":
                    ShowDoanhThuTheoHinhThuc();
                    break;
                default:
                    MessageBox.Show("Chưa có báo cáo này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
