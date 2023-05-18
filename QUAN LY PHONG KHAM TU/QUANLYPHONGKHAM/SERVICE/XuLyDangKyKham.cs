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

        public DataTable TaiDanhSachDangKyKham()
        {
            query = $"SELECT Ds.STT, Ds.MaBenhNhan, Bn.HoTen, Tt.TenTinhTrang " +
                $"FROM dbo.DanhSachKham AS Ds JOIN dbo.BenhNhan AS Bn ON Ds.MaBenhNhan = Bn.MaBenhNhan " +
                $"JOIN dbo.TinhTrang AS Tt ON Ds.MaTinhTrang = Tt.MaTinhTrang";
            DataTable table1 = _dataProvider.ExecuteQuery(query);
            return table1;
        }

        public bool DaDangKyKhamCungNgay(string ngaykham, int mabn)
        {
            query = $"SELECT * FROM dbo.DanhSachKham WHERE MaBenhNhan = {mabn} AND NgayKham = '{ngaykham}'";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result <= 0)
            {
                return false;
            }
            return true;
        }
        
        public bool DangKyKham(string smabn, string ngaykham, ref string thongbao)
        {
            int mabn = _xuLyBenhNhan.TonTaiMaBenhNhan(smabn, ref thongbao);
            if (mabn < 0)
            {
                return false;
            }

            if(DaDangKyKhamCungNgay(ngaykham, mabn))
            {
                thongbao = $"Bệnh nhân có mã bệnh nhân {mabn} đã đăng ký khám ngày {ngaykham}";
                return false;
            }

            query = "SELECT MAX(MaDangKy) FROM dbo.DanhSachKham";
            int madk = _xuLyChung.TaoSoThuTu(query);

            query = $"SELECT MAX(STT) FROM dbo.DanhSachKham WHERE NgayKham = '{ngaykham}'";
            int stt = _xuLyChung.TaoSoThuTu(query);

            query = $"INSERT dbo.DanhSachKham (MaDangKy, NgayKham, STT, MaBenhNhan, MaPhieuKham, MaHoaDon, MaTinhTrang) " +
                $"VALUES ({madk} , '{ngaykham}', {stt} , {mabn} , NULL , NULL , 'ChoKham')";
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
    }
}
