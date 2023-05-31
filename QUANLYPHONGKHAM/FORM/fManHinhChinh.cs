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
using QUANLYPHONGKHAM.ENTITIES;

namespace QUANLYPHONGKHAM.FORM
{
    public partial class fManHinhChinh : Form
    {
        private IXuLyTaiKhoan _xuLyTaiKhoan = new XuLyTaiKhoan();
        private IXuLyChung _xuLyChung = new XuLyChung();
        private TaiKhoan taikhoan;
        public fManHinhChinh(string tentaikhoan)
        {
            InitializeComponent();
            this.taikhoan = _xuLyTaiKhoan.ThongTinTaiKhoan(tentaikhoan);
            lHienThiTen.Text = $"Xin chào {this.taikhoan.TenHienThi}!";
            PhanQuyen(this.taikhoan.MaLoaiTaiKhoan);
        }

         
        public void PhanQuyen(int loaitaikhoan)
        {
            if (loaitaikhoan == 2) //Bác sĩ
            {
                msManHinhChinh.Items[0].Enabled = false;
                var phongkham = (ToolStripMenuItem)msManHinhChinh.Items[1];
                phongkham.DropDownItems[0].Enabled = false;
                phongkham.DropDownItems[2].Enabled = false;
                msManHinhChinh.Items[2].Enabled = false;
                msManHinhChinh.Items[3].Enabled = false;
            }
            else if (loaitaikhoan == 3) //Nhân viên
            {
                msManHinhChinh.Items[0].Enabled = false;
                var phongkham = (ToolStripMenuItem)msManHinhChinh.Items[1];
                phongkham.DropDownItems[1].Enabled = false;
                phongkham.DropDownItems[2].Enabled = false;
                msManHinhChinh.Items[2].Enabled = false;
            }    
            else if (loaitaikhoan == 4) //Thu ngân
            {
                msManHinhChinh.Items[0].Enabled = false;
                msManHinhChinh.Items[1].Enabled = false;
                msManHinhChinh.Items[2].Enabled = false;
            }    
        }

        private void đăngKýKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangKyKham f = new fDangKyKham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void danhSáchThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanhMucThuoc f = new fDanhMucThuoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void xuấtPhiếuKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhieuKham f = new fPhieuKham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp f = new temp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaiKhoan f = new fTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(taikhoan);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
