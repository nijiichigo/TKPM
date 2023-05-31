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
using QUANLYPHONGKHAM.ENTITIES;

namespace QUANLYPHONGKHAM.FORM
{
    public partial class fTaiKhoan : Form
    {
        private IXuLyTaiKhoan _xuLyTaiKhoan = new XuLyTaiKhoan();
        private TaiKhoan taikhoan
        {
            get
            {
                TaiKhoan result = new TaiKhoan();
                result.TenTaiKhoan = tbTenTaiKhoan.Text.ToString();
                result.TenHienThi = tbTenHienThi.Text.ToString();
                result.MatKhau = tbMatKhau.Text.ToString();
                result.MaLoaiTaiKhoan = _xuLyTaiKhoan.MaLoaiTaiKhoan(cbLoaiTaiKhoan.Text.ToString());
                return result;
            }
        }
        private string xnmatkhau { get { return tbXacNhanMatKhau.Text.ToString(); } }
        private string loaitimkiem { get { return cbLoaiTimKiem.Text.ToString(); } }
        private string tukhoa { get { return tbTuKhoa.Text.ToString(); } }
        private string thongbao = string.Empty;

        public fTaiKhoan()
        {
            InitializeComponent();
            TaiDanhSachTaiKhoan();
        }

        private void XoaInput()
        {
            tbTenTaiKhoan.Clear();
            tbTenHienThi.Clear();
            tbMatKhau.Clear();
            tbXacNhanMatKhau.Clear();
            cbLoaiTaiKhoan.SelectedIndex = -1;
            cbLoaiTimKiem.SelectedIndex = -1;
            tbTuKhoa.Clear();
        }

        private void HeaderDanhSachTaiKhoan()
        {
            dgvTaiKhoan.Columns[0].HeaderText = "Tên tài khoản";
            dgvTaiKhoan.Columns[1].HeaderText = "Tên hiển thị";
            dgvTaiKhoan.Columns[2].HeaderText = "Loại tài khoản";
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTaiKhoan.CurrentRow.Index;
            tbTenTaiKhoan.Text = dgvTaiKhoan.Rows[i].Cells[0].Value.ToString();
            tbTenHienThi.Text = dgvTaiKhoan.Rows[i].Cells[1].Value.ToString();
            cbLoaiTaiKhoan.Text = dgvTaiKhoan.Rows[i].Cells[2].Value.ToString();
        }

        private void TaiDanhSachTaiKhoan()
        {
            dgvTaiKhoan.DataSource = _xuLyTaiKhoan.TaiDanhSachTaiKhoan();
            HeaderDanhSachTaiKhoan();
        }

        private void bXoaForm_Click(object sender, EventArgs e)
        {
            XoaInput();
        }

        private void bReload_Click(object sender, EventArgs e)
        {
            TaiDanhSachTaiKhoan();
        }

        private void bDangKy_Click(object sender, EventArgs e)
        {
            bool themtk = _xuLyTaiKhoan.ThemTaiKhoan(taikhoan, xnmatkhau, ref thongbao);

            if (themtk)
            {
                MessageBox.Show(thongbao);
                TaiDanhSachTaiKhoan();
                XoaInput();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xóa tài khoản {taikhoan.TenTaiKhoan}?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool xoatk = _xuLyTaiKhoan.XoaTaiKhoan(taikhoan.TenTaiKhoan, ref thongbao);
                if (xoatk)
                {
                    MessageBox.Show(thongbao);
                    TaiDanhSachTaiKhoan();
                    XoaInput();
                }
                else
                {
                    MessageBox.Show(thongbao);
                }
            }
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            bool dieuchinhtkn = _xuLyTaiKhoan.DieuChinhTaiKhoan(taikhoan, ref thongbao);

            if (dieuchinhtkn)
            {
                MessageBox.Show(thongbao);
                TaiDanhSachTaiKhoan();
                XoaInput();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bTimKiem_Click(object sender, EventArgs e)
        {
            if ((tukhoa == "") || (loaitimkiem == ""))
            {
                MessageBox.Show("Vui lòng nhập từ khóa và loại tra cứu!");
            }
            else
            {
                DataTable timkiem = _xuLyTaiKhoan.TimKiemTaiKhoan(tukhoa, loaitimkiem);
                dgvTaiKhoan.DataSource = timkiem;
            }
        }
    }
}
