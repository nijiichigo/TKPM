using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYPHONGKHAM.DAL;

namespace QUANLYPHONGKHAM.SERVICE
{
    public class XuLyDangKyKham : IXuLyDangKyKham
    {
        private IDataProvider _dataProvider = new DataProvider();
        private IXuLyBenhNhan _xuLyBenhNhan = new XuLyBenhNhan();
        private IXuLyChung _xuLyChung = new XuLyChung();
        private string query = string.Empty;

        public DataTable TaiDanhSachDangKyKham(string ngaykham)
        {
            query = $"SELECT Ds.STT, Ds.MaBenhNhan, Bn.HoTen " +
                $"FROM dbo.DanhSachKham AS Ds JOIN dbo.BenhNhan AS Bn ON Ds.MaBenhNhan = Bn.MaBenhNhan AND Ds.NgayKham = '{ngaykham}'";
            DataTable table1 = _dataProvider.ExecuteQuery(query);
            return table1;
        }

        public bool DaDangKyKham(string ngaykham, string mabn)
        {
            query = $"SELECT * FROM dbo.DanhSachKham WHERE MaBenhNhan = {mabn} AND NgayKham = '{ngaykham}'";
            if (_xuLyChung.KiemTraTonTai(query))
            {
                return true;
            }
            return false;
        }

        public bool DangKyKham(string mabn, string ngaykham, ref string thongbao)
        {
            if (!_xuLyBenhNhan.KiemTraTonTaiMaBenhNhan(mabn))
            {
                thongbao = $"Mã bệnh nhân {mabn} không tồn tại!";
                return false;
            }

            if (DaDangKyKham(ngaykham, mabn))
            {
                thongbao = $"Bệnh nhân có mã bệnh nhân {mabn} đã đăng ký khám ngày {ngaykham}";
                return false;
            }

            query = $"SELECT MAX(MaDangKy) FROM dbo.DanhSachKham";
            int madk = _xuLyChung.TaoSoThuTu(query);

            query = $"SELECT MAX(STT) FROM dbo.DanhSachKham WHERE NgayKham = '{ngaykham}'";
            int stt = _xuLyChung.TaoSoThuTu(query);

            query = $"INSERT dbo.DanhSachKham (MaDangKy, NgayKham, STT, MaBenhNhan, MaPhieuKham, MaDonThuoc, MaHoaDon, MaTinhTrang) " +
                $"VALUES ({madk} , '{ngaykham}', {stt} , {mabn} , NULL , NULL , NULL , 'ChoKham')";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Đăng ký khám thành công!";
                return true;
            }
            else
            {
                thongbao = "Đăng ký khám không thành công!";
                return false;
            }
        }

        public void CapNhatSTT(string ngaykham, string mabn)
        {
            query = $"SELECT STT FROM dbo.DanhSachKham WHERE MaBenhNhan = {mabn} AND NgayKham = '{ngaykham}'";
            int stt = _xuLyChung.TraMaSo(query);

            query = $"SELECT MAX(STT) FROM dbo.DanhSachKham WHERE NgayKham = '{ngaykham}'";
            int max = _xuLyChung.TraMaSo(query);

            if (stt < max)
            {
                for (int i = stt; i <= max; i++)
                {
                    query = $"UPDATE dbo.DanhSachKham SET STT = {i} WHERE NgayKham = '{ngaykham}' AND STT = {i + 1}";
                    _dataProvider.ExecuteNonQuery(query);
                }
            }
        }

        public bool HuyKham(string mabn, string ngaykham, ref string thongbao)
        {
            if (!_xuLyBenhNhan.KiemTraTonTaiMaBenhNhan(mabn))
            {
                thongbao = $"Mã bệnh nhân {mabn} không tồn tại!";
                return false;
            }

            if (!DaDangKyKham(ngaykham, mabn))
            {
                thongbao = $"Bệnh nhân có mã bệnh nhân {mabn} chưa đăng ký khám ngày {ngaykham}";
                return false;
            }

            CapNhatSTT(ngaykham, mabn);
            query = $"DELETE FROM dbo.DanhSachKham WHERE MaBenhNhan = {mabn} AND NgayKham = '{ngaykham}'";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Hủy đăng ký khám thành công!";
                return true;
            }
            else
            {
                thongbao = "Hủy đăng ký khám không thành công!";
                return false;
            }
        }
    }
}
