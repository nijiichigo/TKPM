using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYPHONGKHAM.SERVICE;
using QUANLYPHONGKHAM.DAL;

namespace QUANLYPHONGKHAM.FORM
{
    public partial class fDangKyKham : Form
    {
        private IXuLyBenhNhan _xuLyBenhNhan = new XuLyBenhNhan();
        public fDangKyKham()
        {
            InitializeComponent();
            TaiDanhSachBenhNhan();
        }

        private void TaiDanhSachBenhNhan()
        {
            dgvDanhSachBenhNhan.DataSource = _xuLyBenhNhan.TaiDanhSachBenhNhan();
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            string hoten = tbHoTen.Text.ToString();
            string namsinh = tbNamSinh.Text.ToString();
            string gioitinh = cbbGioiTinh.Text.ToString();
            string dienthoai = tbDienThoai.Text.ToString();
            string diachi = tbDiaChi.Text.ToString();
            string thongbao = string.Empty;
            bool thembenhnhan = _xuLyBenhNhan.ThemBenhNhan(hoten, namsinh, gioitinh, dienthoai, diachi, ref thongbao);

            if (thembenhnhan)
            {
                MessageBox.Show(thongbao);
                dgvDanhSachBenhNhan.DataSource = _xuLyBenhNhan.TaiDanhSachBenhNhan();
                tbMaBenhNhan.Clear();
                tbHoTen.Clear();
                tbNamSinh.Clear();
                cbbGioiTinh.Items.Clear();
                tbDiaChi.Clear();
                tbDienThoai.Clear();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }
    }
}
