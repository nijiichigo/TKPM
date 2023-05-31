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
    public partial class fDoiMatKhau : Form
    {
        private IDataProvider _dataProvider = new DataProvider();
        private IXuLyTaiKhoan _xuLyTaiKhoan = new XuLyTaiKhoan();
        private TaiKhoan taikhoan;
        private string thongbao;
        private string matkhaucu { get { return tbMatKhau.Text.ToString(); } }
        private string matkhaumoi { get { return tbMatKhauMoi.Text.ToString(); } }
        private string matkhauxacnhan { get { return tbXacNhanMatKhau.Text.ToString(); } }
        public fDoiMatKhau(TaiKhoan taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            tbTenTaiKhoan.Text = this.taikhoan.TenTaiKhoan;
            tbTenHienThi.Text = this.taikhoan.TenHienThi;
        }

        private void bDoiMatKhau_Click(object sender, EventArgs e)
        {
            bool doimatkhau = _xuLyTaiKhoan.DoiMatKhau(taikhoan, matkhaucu, matkhaumoi, matkhauxacnhan, ref thongbao);
            if (doimatkhau)
            {
                MessageBox.Show(thongbao);
                this.Close();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }
    }
}
