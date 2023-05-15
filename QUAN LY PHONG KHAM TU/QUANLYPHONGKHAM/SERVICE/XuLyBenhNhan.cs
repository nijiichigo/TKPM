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

        public int TonTaiMaBenhNhan(string smabn, ref string thongbao)
        {
            int mabn;
            if (!(int.TryParse(smabn, out mabn)))
            {
                thongbao = "Mã bệnh nhân không hợp lệ!";
                return -1;
            }
            mabn = int.Parse(smabn);

            query = $"SELECT * FROM dbo.BenhNhan WHERE MaBenhNhan = {mabn}";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result <= 0)
            {   
                return -1;
            }
            return mabn;
        }

        public bool KiemTraThongTin(string hoten, string snamsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao)
        {
            int num;
            if (int.TryParse(snamsinh, out num))
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

            if ((hoten == "") || (snamsinh == "") || (gioitinh == "") || (dienthoai == "") || (diachi == ""))
            {
                thongbao = "Vui lòng điền đầy đủ thông tin!";
                return false;
            }
            return true;
        }

        public bool ThemBenhNhan(string hoten, string snamsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao)
        {
            query = "SELECT MAX(MaBenhNhan) FROM dbo.BenhNhan";
            int mabn = _xuLyChung.TaoSoThuTu(query);

            if (!KiemTraThongTin(hoten, snamsinh, gioitinh, dienthoai, diachi, ref thongbao))
            {
                return false;
            }
            int namsinh = int.Parse(snamsinh);
            
            query = $"INSERT dbo.BenhNhan (MaBenhNhan, HoTen, NamSinh, GioiTinh, DienThoai, DiaChi) VALUES ({mabn} , N'{hoten}' , {namsinh} , N'{gioitinh}' , '{dienthoai}' , N'{diachi}')";
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

        public bool DieuChinhBenhNhan(string smabn, string hoten, string snamsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao)
        {
            int mabn = TonTaiMaBenhNhan(smabn, ref thongbao);
            if (mabn < 0)
            {                
                return false;
            }

            if (!KiemTraThongTin(hoten, snamsinh, gioitinh, dienthoai, diachi, ref thongbao))
            {
                return false;
            }
            int namsinh = int.Parse(snamsinh);

            query = $"UPDATE dbo.BenhNhan SET HoTen = N'{hoten}', NamSinh = {namsinh}, GioiTinh = N'{gioitinh}', DienThoai = '{dienthoai}', DiaChi = N'{diachi}' WHERE MaBenhNhan = {mabn}";
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

        public bool XoaBenhNhan(string smabn, ref string thongbao)
        {
            int mabn = TonTaiMaBenhNhan(smabn, ref thongbao);
            if (mabn < 0)
            {
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

        public DataTable TimKiemBenhNhan(string tukhoa, string loai)
        {
            DataTable result = new DataTable();
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
