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
    public partial class fPhieuKham : Form
    {
        private IXuLyBenhNhan _xuLyBenhNhan = new XuLyBenhNhan();
        private IXuLyDangKyKham _xuLyDangKyKham = new XuLyDangKyKham();
        private string ngaykham { get { return tbNgayKham.Text.ToString(); } }
        private string bacsi { get { return tbBacSi.Text.ToString(); } }
        private string mabn { get { return tbMaBenhNhan.Text.ToString(); } }
        private string trieuchung { get { return tbTrieuChung.Text.ToString(); } }
        private string chandoan { get { return tbChanDoan.Text.ToString(); } }
        private string loidan { get { return tbLoiDan.Text.ToString(); } }
        private string tenthuoc { get { return tbTenThuoc.Text.ToString(); } }
        private string soluong { get { return tbSoLuong.Text.ToString(); } }
        private string cachdung { get { return tbCachDung.Text.ToString(); } }
        public fPhieuKham()
        {
            InitializeComponent();
        }
    }
}
