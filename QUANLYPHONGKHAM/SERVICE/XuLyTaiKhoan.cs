using QUANLYPHONGKHAM.DAL;
using QUANLYPHONGKHAM.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.SERVICE
{
    public class XuLyTaiKhoan : IXuLyTaiKhoan
    {
        private IDataProvider _dataProvider = new DataProvider();
        private IXuLyChung _xuLyChung = new XuLyChung();
        private string query = string.Empty;

        public bool DangNhap(string tendangnhap, string matkhau)
        {
            query = $"SELECT * FROM dbo.TaiKhoan WHERE TenTaiKhoan = '{tendangnhap}' AND MatKhau = '{matkhau}'";
            return _xuLyChung.KiemTraTonTai(query);
        }

        public TaiKhoan ThongTinTaiKhoan(string tentaikhoan)
        {
            TaiKhoan result = new TaiKhoan();
            query = $"SELECT * FROM dbo.TaiKhoan WHERE TenTaiKhoan = '{tentaikhoan}'";
            DataTable d = _dataProvider.ExecuteQuery(query);
            result.TenTaiKhoan = d.Rows[0]["TenTaiKhoan"].ToString();
            result.TenHienThi = d.Rows[0]["TenHienThi"].ToString();
            result.MatKhau = d.Rows[0]["MatKhau"].ToString();
            result.MaLoaiTaiKhoan = int.Parse(d.Rows[0]["MaLoaiTaiKhoan"].ToString());
            return result;
        }

        public DataTable TaiDanhSachTaiKhoan()
        {
            query = $"SELECT Tk.TenTaiKhoan, Tk.TenHienThi, Ltk.TenLoaiTaiKhoan FROM dbo.TaiKhoan AS Tk JOIN dbo.LoaiTaiKhoan AS Ltk ON Tk.MaLoaiTaiKhoan = Ltk.MaLoaiTaiKhoan";
            DataTable result = _dataProvider.ExecuteQuery(query);
            return result;
        }
        public bool KiemTraTonTaiTaiKhoan (string tentaikhoan)
        {
            query = $"SELECT TenTaiKhoan FROM dbo.TaiKhoan WHERE TenTaiKhoan = '{tentaikhoan}'";
            return _xuLyChung.KiemTraTonTai(query);
        }

        public int MaLoaiTaiKhoan(string loaitk)
        {
            if (loaitk == "Quản lý")
            {
                return 1;
            }
            else if (loaitk == "Bác sĩ")
            {
                return 2;
            }
            else if (loaitk == "Nhân viên")
            {
                return 3;
            }
            else if (loaitk == "Thu ngân")
            {
                return 4;
            }
            return -1;
        }

        public bool ThemTaiKhoan(TaiKhoan taikhoan, string xnmatkhau, ref string thongbao)
        {
            if ((taikhoan.TenHienThi == "") || (taikhoan.TenTaiKhoan == "") || (taikhoan.MatKhau == "") || (xnmatkhau == "") || (taikhoan.MaLoaiTaiKhoan == -1))
            {
                thongbao = "Vui lòng điền đầy đủ thông tin!";
                return false;
            }    

            if (KiemTraTonTaiTaiKhoan(taikhoan.TenTaiKhoan))
            {
                thongbao = $"Tài khoản có tên {taikhoan.TenTaiKhoan} đã tồn tại!";
                return false;
            }

            if (taikhoan.MatKhau != xnmatkhau)
            {
                thongbao = "Xác nhận mật khẩu không trùng khớp!";
                return false;
            }    

            query = $"INSERT dbo.TaiKhoan (TenTaiKhoan, TenHienThi, MatKhau, MaLoaiTaiKhoan)" +
                $"VALUES ('{taikhoan.TenTaiKhoan}' , N'{taikhoan.TenHienThi}' , '{taikhoan.MatKhau}' , {taikhoan.MaLoaiTaiKhoan})";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Đăng ký tài khoản thành công!";
                return true;
            }
            else
            {
                thongbao = "Đăng ký tài khoản không thành công!";
                return false;
            }
        }

        public bool XoaTaiKhoan(string tentaikhoan, ref string thongbao)
        {
            if (tentaikhoan == "")
            {
                thongbao = "Vui lòng điền đầy đủ thông tin!";
                return false;
            }    

            if (!KiemTraTonTaiTaiKhoan(tentaikhoan))
            {
                thongbao = $"Tài khoản {tentaikhoan} không tồn tại!";
                return false;
            }
            query = $"DELETE FROM dbo.TaiKhoan WHERE TenTaiKhoan = '{tentaikhoan}'";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Xóa tài khoản thành công!";
                return true;
            }
            else
            {
                thongbao = "Xóa tài khoản không thành công!";
                return false;
            }
        }

        public bool DieuChinhTaiKhoan(TaiKhoan taikhoan, ref string thongbao)
        {
            if ((taikhoan.TenTaiKhoan == "") || (taikhoan.TenHienThi == "") || (taikhoan.MaLoaiTaiKhoan == -1))
            {
                thongbao = "Vui lòng điền đầy đủ thông tin!";
                return false;
            }

            if (!KiemTraTonTaiTaiKhoan(taikhoan.TenTaiKhoan))
            {
                thongbao = $"Tài khoản {taikhoan.TenTaiKhoan} không tồn tại!";
                return false;
            }

            query = $"UPDATE dbo.TaiKhoan SET " +
                $"TenHienThi = N'{taikhoan.TenHienThi}', MaLoaiTaiKhoan = {taikhoan.MaLoaiTaiKhoan} WHERE TenTaiKhoan = '{taikhoan.TenTaiKhoan}'";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Cập nhật thông tin tài khoản thành công!";
                return true;
            }
            else
            {
                thongbao = "Cập nhật thông tin tài khoản không thành công!";
                return false;
            }
        }

        public DataTable TimKiemTaiKhoan(string tukhoa, string loai)
        {
            if ((loai == "Tên tài khoản") || (loai == "Tên hiển thị"))
            {
                if (loai == "Tên tài khoản")
                {
                    loai = "TenTaiKhoan";
                }
                else
                {
                    loai = "TenHienThi";
                }

                query = $"SELECT Tk.TenTaiKhoan, Tk.TenHienThi, Ltk.TenLoaiTaiKhoan FROM dbo.TaiKhoan AS Tk JOIN dbo.LoaiTaiKhoan AS Ltk " +
                    $"ON Tk.MaLoaiTaiKhoan = Ltk.MaLoaiTaiKhoan WHERE Tk.{loai} LIKE N'%{tukhoa}%'";
            }
            else
            {
                query = $"SELECT Tk.TenTaiKhoan, Tk.TenHienThi, Ltk.TenLoaiTaiKhoan FROM dbo.TaiKhoan AS Tk JOIN dbo.LoaiTaiKhoan AS Ltk " +
                    $"ON Tk.MaLoaiTaiKhoan = Ltk.MaLoaiTaiKhoan WHERE Ltk.TenLoaiTaiKhoan LIKE N'%{tukhoa}%'";
            }
            return _dataProvider.ExecuteQuery(query);
        }

        public bool DoiMatKhau(TaiKhoan taikhoan, string matkhaucu, string matkhaumoi, string matkhauxacnhan, ref string thongbao)
        {
            if ((matkhaucu == "") || (matkhaumoi == "") || (matkhauxacnhan == ""))
            {
                thongbao = "Vui lòng điền đầy đủ thông tin!";
                return false;
            }
            if (taikhoan.MatKhau != matkhaucu)
            {
                thongbao = "Mật khẩu không chính xác!";
                return false;
            }
            if (matkhauxacnhan != matkhaumoi)
            {
                thongbao = "Xác nhận mật khẩu mới không trùng khớp";
                return false;
            }    

            query = $"UPDATE dbo.TaiKhoan SET " +
                $"MatKhau = '{matkhaumoi}' WHERE TenTaiKhoan = '{taikhoan.TenTaiKhoan}'";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Đổi mật khẩu thành công!";
                return true;
            }
            else
            {
                thongbao = "Đổi mật khẩu không thành công!";
                return false;
            }
        }
    }
}
