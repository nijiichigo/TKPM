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
        private IXuLyDangKyKham _xuLyDangKyKham = new XuLyDangKyKham();
        private string mabn { get { return tbMaBenhNhan.Text.ToString(); } }
        private string hoten { get { return tbHoTen.Text.ToString(); } }
        private string namsinh { get { return tbNamSinh.Text.ToString(); } }
        private string gioitinh { get { return cbbGioiTinh.Text.ToString(); } }
        private string dienthoai { get { return tbDienThoai.Text.ToString(); } }
        private string diachi { get { return tbDiaChi.Text.ToString(); } }
        private string ngaykham { get { return tbNgay.Text.ToString(); } }
        private string mbnkham { get { return lMaBNKham.Text.ToString(); } }
        private string loai { get { return cbLoai.Text.ToString(); } }
        private string tukhoa { get { return tbTuKhoa.Text.ToString(); } }
        private string thongbao = string.Empty;

        public fDangKyKham()
        {
            InitializeComponent();
            NgayDangKy();
            TaiDanhSachBenhNhan();
            TaiDanhSachDangKyKham();
            HeaderDanhSachBenhNhan();
            HeaderDanhSachKham();
        }

        private void XoaInput()
        {
            tbMaBenhNhan.Clear();
            tbHoTen.Clear();
            tbNamSinh.Clear();
            cbbGioiTinh.SelectedIndex = -1;
            tbDiaChi.Clear();
            tbDienThoai.Clear();
            cbLoai.SelectedIndex = -1;
            tbTuKhoa.Clear();
        }

        //------------BỆNH NHÂN----------------
        private void HeaderDanhSachBenhNhan()
        {
            dgvDanhSachBenhNhan.Columns[0].HeaderText = "Mã bệnh nhân";
            dgvDanhSachBenhNhan.Columns[1].HeaderText = "Họ tên";
            dgvDanhSachBenhNhan.Columns[2].HeaderText = "Năm sinh";
            dgvDanhSachBenhNhan.Columns[3].HeaderText = "Giới tính";
            dgvDanhSachBenhNhan.Columns[4].HeaderText = "Điện thoại";
            dgvDanhSachBenhNhan.Columns[5].HeaderText = "Địa chỉ";
        }

        private void TaiDanhSachBenhNhan()
        {
            dgvDanhSachBenhNhan.DataSource = _xuLyBenhNhan.TaiDanhSachBenhNhan();
        }

        private void dgvDanhSachBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDanhSachBenhNhan.CurrentRow.Index;
            tbMaBenhNhan.Text = dgvDanhSachBenhNhan.Rows[i].Cells[0].Value.ToString();
            tbHoTen.Text = dgvDanhSachBenhNhan.Rows[i].Cells[1].Value.ToString();
            tbNamSinh.Text = dgvDanhSachBenhNhan.Rows[i].Cells[2].Value.ToString();
            cbbGioiTinh.Text = dgvDanhSachBenhNhan.Rows[i].Cells[3].Value.ToString();
            tbDienThoai.Text = dgvDanhSachBenhNhan.Rows[i].Cells[4].Value.ToString();
            tbDiaChi.Text = dgvDanhSachBenhNhan.Rows[i].Cells[5].Value.ToString();
        }

        private void bXoaForm_Click(object sender, EventArgs e)
        {
            XoaInput();
        }

        private void bReloadDanhSach_Click(object sender, EventArgs e)
        {
            TaiDanhSachBenhNhan();
        }

        private void bDangKyBN_Click(object sender, EventArgs e)
        {
            bool thembenhnhan = _xuLyBenhNhan.ThemBenhNhan(hoten, namsinh, gioitinh, dienthoai, diachi, ref thongbao);

            if (thembenhnhan)
            {
                MessageBox.Show(thongbao);
                dgvDanhSachBenhNhan.DataSource = _xuLyBenhNhan.TaiDanhSachBenhNhan();
                XoaInput();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bXoaBN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xóa bệnh nhân {hoten} - mã bệnh nhân: {mabn}?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool xoabenhnhan = _xuLyBenhNhan.XoaBenhNhan(mabn, ref thongbao);
                if (xoabenhnhan)
                {
                    MessageBox.Show(thongbao);
                    dgvDanhSachBenhNhan.DataSource = _xuLyBenhNhan.TaiDanhSachBenhNhan();
                    XoaInput();
                }
                else
                {
                    MessageBox.Show(thongbao);
                }
            }
        }

        private void bDieuChinh_Click(object sender, EventArgs e)
        {
            bool dieuchinhbenhnhan = _xuLyBenhNhan.DieuChinhBenhNhan(mabn, hoten, namsinh, gioitinh, dienthoai, diachi, ref thongbao);

            if (dieuchinhbenhnhan)
            {
                MessageBox.Show(thongbao);
                dgvDanhSachBenhNhan.DataSource = _xuLyBenhNhan.TaiDanhSachBenhNhan();
                XoaInput();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bTimKiem_Click(object sender, EventArgs e)
        {
            if ((tukhoa == "") || (loai == ""))
            {
                MessageBox.Show("Vui lòng nhập từ khóa và loại tra cứu!");
            }
            else
            {
                DataTable timkiem = _xuLyBenhNhan.TimKiemBenhNhan(tukhoa, loai);
                dgvDanhSachBenhNhan.DataSource = timkiem;
            }
        }

        //------------ĐĂNG KÝ KHÁM---------------
        private void HeaderDanhSachKham()
        {
            dgvDanhSachKham.Columns[0].HeaderText = "Số thứ tự";
            dgvDanhSachKham.Columns[1].HeaderText = "Mã bệnh nhân";
            dgvDanhSachKham.Columns[2].HeaderText = "Họ tên";
        }

        private void NgayDangKy()
        {
            tbNgay.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void TaiDanhSachDangKyKham()
        {
            dgvDanhSachKham.DataSource = _xuLyDangKyKham.TaiDanhSachDangKyKham(ngaykham);
        }

        private void dgvDanhSachKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDanhSachKham.CurrentRow.Index;
            lMaBNKham.Text = dgvDanhSachKham.Rows[i].Cells[1].Value.ToString();
        }

        private void bDangKyKham_Click(object sender, EventArgs e)
        {
            bool dangkykham = _xuLyDangKyKham.DangKyKham(mabn, ngaykham, ref thongbao);

            if (dangkykham)
            {
                MessageBox.Show(thongbao);
                dgvDanhSachKham.DataSource = _xuLyDangKyKham.TaiDanhSachDangKyKham(ngaykham);
                XoaInput();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bHuyKham_Click(object sender, EventArgs e)
        {
            bool huykham = _xuLyDangKyKham.HuyKham(mbnkham, ngaykham, ref thongbao);
            if (huykham)
            {
                MessageBox.Show(thongbao);
                dgvDanhSachKham.DataSource = _xuLyDangKyKham.TaiDanhSachDangKyKham(ngaykham);
                XoaInput();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }
    }
}
