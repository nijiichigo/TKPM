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
using QUANLYPHONGKHAM.FORM;

namespace QUANLYPHONGKHAM
{
    public partial class fDangNhap : Form
    {
        private IXuLyTaiKhoan _xuLyTaiKhoan = new XuLyTaiKhoan();
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void bDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = tbTenDangNhap.Text;
            string matkhau = tbMatKhau.Text;
            if (_xuLyTaiKhoan.DangNhap(tendangnhap, matkhau))
            {
                fManHinhChinh f = new fManHinhChinh(tendangnhap);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
            }
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
