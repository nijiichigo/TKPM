using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYPHONGKHAM.DAL;

namespace QUANLYPHONGKHAM.SERVICE
{
    public class XuLyBenhNhan : IXuLyBenhNhan
    {
        private IDataProvider _dataProvider = new DataProvider();
        private IXuLyChung _xuLyChung = new XuLyChung();
        private string query = string.Empty;

        public DataTable TaiDanhSachBenhNhan()
        {
            query = $"SELECT * FROM dbo.BenhNhan";
            DataTable result = _dataProvider.ExecuteQuery(query);
            return result;
        }

        public bool KiemTraThongTin(string hoten, string namsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao)
        {
            if ((hoten == "") || (namsinh == "") || (gioitinh == "") || (dienthoai == "") || (diachi == ""))
            {
                thongbao = "Vui lòng điền đầy đủ thông tin!";
                return false;
            }

            if (int.TryParse(namsinh, out int num))
            {
                if ((num > DateTime.Now.Year) || (num <= 1900))
                {
                    thongbao = "Năm sinh không hợp lệ!";
                    return false;
                }
            }
            else
            {
                thongbao = "Năm sinh không hợp lệ!";
                return false;
            }
            return true;
        }

        public bool KiemTraTonTaiMaBenhNhan(string mabn)
        {
            if (_xuLyChung.StringToInt(mabn) >= 0)
            {
                query = $"SELECT * FROM dbo.BenhNhan WHERE MaBenhNhan = {mabn}";
                if (_xuLyChung.KiemTraTonTai(query))
                {
                    return true;
                }
            }
            return false;
        }

        public bool KiemTraTonTaiBenhNhan(string hoten, string namsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao)
        {
            query = $"SELECT * FROM dbo.BenhNhan WHERE " +
                $"HoTen = N'{hoten}' AND NamSinh = {namsinh} AND GioiTinh = N'{gioitinh}' AND DienThoai = '{dienthoai}' AND DiaChi = N'{diachi}'";
            if (_xuLyChung.KiemTraTonTai(query))
            {
                return true;
            }
            return false;
        }

        public bool KiemTraBenhNhanTungDangKyKham(string mabn)
        {
            query = $"SELECT * FROM dbo.DanhSachKham WHERE MaBenhNhan = {mabn}";
            if (_xuLyChung.KiemTraTonTai(query))
            {
                return true;
            }
            return false;
        }

        public bool ThemBenhNhan(string hoten, string namsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao)
        {
            query = $"SELECT MAX(MaBenhNhan) FROM dbo.BenhNhan";
            int mabn = _xuLyChung.TaoSoThuTu(query);

            if (!KiemTraThongTin(hoten, namsinh, gioitinh, dienthoai, diachi, ref thongbao))
            {
                return false;
            }

            if (KiemTraTonTaiBenhNhan(hoten, namsinh, gioitinh, dienthoai, diachi, ref thongbao))
            {
                thongbao = "Bệnh nhân này đã được đăng ký trong danh sách bệnh nhân!";
                return false;
            }

            query = $"INSERT dbo.BenhNhan (MaBenhNhan, HoTen, NamSinh, GioiTinh, DienThoai, DiaChi) " +
                $"VALUES ({mabn} , N'{hoten}' , {namsinh} , N'{gioitinh}' , '{dienthoai}' , N'{diachi}')";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Thêm bệnh nhân thành công!";
                return true;
            }
            else
            {
                thongbao = "Thêm bệnh nhân không thành công!";
                return false;
            }
        }

        public bool XoaBenhNhan(string mabn, ref string thongbao)
        {
            if (!KiemTraTonTaiMaBenhNhan(mabn))
            {
                thongbao = $"Mã bệnh nhân {mabn} không tồn tại!";
                return false;
            }

            if (KiemTraBenhNhanTungDangKyKham(mabn))
            {
                thongbao = $"Bệnh nhân có mã {mabn} đã từng đăng ký khám. Không được xóa bệnh nhân!";
                return false;
            }

            query = $"DELETE FROM dbo.BenhNhan WHERE MaBenhNhan = {mabn}";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Xóa bệnh nhân thành công!";
                return true;
            }
            else
            {
                thongbao = "Xóa bệnh nhân không thành công!";
                return false;
            }
        }

        public bool DieuChinhBenhNhan(string mabn, string hoten, string namsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao)
        {
            if (!KiemTraTonTaiMaBenhNhan(mabn))
            {
                thongbao = $"Mã bệnh nhân {mabn} không tồn tại!";
                return false;
            }

            if (!KiemTraThongTin(hoten, namsinh, gioitinh, dienthoai, diachi, ref thongbao))
            {
                return false;
            }

            query = $"UPDATE dbo.BenhNhan SET " +
                $"HoTen = N'{hoten}', NamSinh = {namsinh}, GioiTinh = N'{gioitinh}', DienThoai = '{dienthoai}', DiaChi = N'{diachi}' WHERE MaBenhNhan = {mabn}";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Cập nhật thông tin bệnh nhân thành công!";
                return true;
            }
            else
            {
                thongbao = "Cập nhật thông tin bệnh nhân không thành công!";
                return false;
            }
        }

        public DataTable TimKiemBenhNhan(string tukhoa, string loai)
        {
            DataTable result = new DataTable();
            if (loai == "Họ tên")
            {
                loai = "HoTen";
            }
            else if (loai == "Năm sinh")
            {
                loai = "NamSinh";
            }
            else if (loai == "Điện thoại")
            {
                loai = "DienThoai";
            }
            else if (loai == "Mã bệnh nhân")
            {
                loai = "MaBenhNhan";
            }

            if ((loai == "HoTen") || (loai == "DienThoai"))
            {
                query = $"SELECT * FROM dbo.BenhNhan WHERE {loai} LIKE N'%{tukhoa}%'";
            }
            else
            {
                int num;
                if (int.TryParse(tukhoa, out num))
                {
                    query = $"SELECT * FROM dbo.BenhNhan WHERE {loai} = {tukhoa}";
                }
                else
                {
                    query = "SELECT * FROM dbo.BenhNhan";
                }
            }
            result = _dataProvider.ExecuteQuery(query);
            return result;
        }
    }
}
