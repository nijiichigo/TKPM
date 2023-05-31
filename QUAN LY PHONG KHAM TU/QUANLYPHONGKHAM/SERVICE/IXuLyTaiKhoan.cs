using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYPHONGKHAM.ENTITIES;

namespace QUANLYPHONGKHAM.SERVICE
{
    public interface IXuLyTaiKhoan
    {
        bool DangNhap(string tendangnhap, string matkhau);
        int MaLoaiTaiKhoan(string loaitk);
        TaiKhoan ThongTinTaiKhoan(string tentaikhoan);
        DataTable TaiDanhSachTaiKhoan();
        bool ThemTaiKhoan(TaiKhoan taikhoan, string xnmatkhau, ref string thongbao);
        bool XoaTaiKhoan(string tentaikhoan, ref string thongbao);
        bool DieuChinhTaiKhoan(TaiKhoan taikhoan, ref string thongbao);
        DataTable TimKiemTaiKhoan(string tukhoa, string loai);
        bool DoiMatKhau(TaiKhoan taikhoan, string matkhaucu, string matkhaumoi, string matkhauxacnhan, ref string thongbao);
    }
}
