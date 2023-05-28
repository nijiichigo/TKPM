using QUANLYPHONGKHAM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.SERVICE
{
    public class XuLyNhomThuoc : IXuLyNhomThuoc
    {
        private IDataProvider _dataProvider = new DataProvider();
        private IXuLyChung _xuLyChung = new XuLyChung();
        private string query = string.Empty;

        public DataTable TaiDanhSachNhomThuoc()
        {
            query = $"SELECT * FROM dbo.NhomThuoc";
            DataTable result = _dataProvider.ExecuteQuery(query);
            return result;
        }

        public bool KiemTraTonTaiMaNhomThuoc(string manhom)
        {
            if (_xuLyChung.StringToInt(manhom) >= 0)
            {
                query = $"SELECT * FROM dbo.NhomThuoc WHERE MaNhom = {manhom}";
                if (_xuLyChung.KiemTraTonTai(query))
                {
                    return true;
                }
            }    
            return false;
        }

        public int KiemTraTonTaiNhomThuoc(string tennhom)
        {
            query = $"SELECT MaNhom FROM dbo.NhomThuoc WHERE TenNhom = N'{tennhom}'";
            if (_xuLyChung.KiemTraTonTai(query))
            {
                return _xuLyChung.TraMaSo(query);
            }
            return -1;
        }

        public bool KiemTraNhomThuocCoThuoc(string manhom)
        {
            query = $"SELECT * FROM dbo.Thuoc WHERE MaNhom = {manhom}";
            if (_xuLyChung.KiemTraTonTai(query))
            {
                return true;
            }
            return false;
        }

        public bool ThemNhomThuoc(string tennhom, ref string thongbao)
        {
            if (tennhom == "")
            {
                thongbao = "Vui lòng điền tên phân loại nhóm thuốc!";
                return false;
            }
            if (KiemTraTonTaiNhomThuoc(tennhom) >= 0)
            {
                thongbao = $"Tên phân loại nhóm thuốc {tennhom} đã tồn tại!";
                return false;
            }
            query = $"SELECT MAX(MaNhom) FROM dbo.NhomThuoc";
            int manhom = _xuLyChung.TaoSoThuTu(query);

            query = $"INSERT dbo.NhomThuoc (MaNhom, TenNhom) VALUES ({manhom} , N'{tennhom}')";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Thêm phân loại nhóm thuốc thành công!";
                return true;
            }
            else
            {
                thongbao = "Thêm phân loại nhóm thuốc không thành công!";
                return false;
            }
        }

        public bool DieuChinhNhomThuoc(string manhom, string tennhom, ref string thongbao)
        {
            if ((manhom == "") || (tennhom == ""))
            {
                thongbao = "Vui lòng điền đầy đủ mã và tên phân loại nhóm thuốc!";
                return false;
            }
            if (!KiemTraTonTaiMaNhomThuoc(manhom))
            {
                thongbao = $"Mã phân loại nhóm thuốc {manhom} không tồn tại!";
                return false;
            }

            if ((KiemTraTonTaiNhomThuoc(tennhom) >= 0) && (KiemTraTonTaiNhomThuoc(tennhom) != int.Parse(manhom)))
            {
                thongbao = $"Tên phân loại nhóm thuốc {tennhom} đã tồn tại!";
                return false;
            }

            query = $"UPDATE dbo.NhomThuoc SET TenNhom = N'{tennhom}' WHERE MaNhom = {manhom}";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Cập nhật phân loại nhóm thuốc thành công!";
                return true;
            }
            else
            {
                thongbao = "Cập nhật phân loại nhóm thuốc không thành công!";
                return false;
            }
        }

        public bool XoaNhomThuoc(string manhom, ref string thongbao)
        {
            if (manhom == "")
            {
                thongbao = "Vui lòng điền mã phân loại nhóm thuốc!";
                return false;
            }
            if (!KiemTraTonTaiMaNhomThuoc(manhom))
            {
                thongbao = $"Mã phân loại nhóm thuốc {manhom} không tồn tại!";
                return false;
            }
            if (KiemTraNhomThuocCoThuoc(manhom))
            {
                thongbao = $"Có thuốc thuộc phân loại nhóm thuốc có mã nhóm là {manhom}. Không được xóa phân loại thuốc này!";
                return false;
            }
            
            query = $"DELETE FROM dbo.NhomThuoc WHERE MaNhom = {manhom}";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Xóa phân loại nhóm thuốc thành công!";
                return true;
            }
            else
            {
                thongbao = "Xóa phân loại nhóm thuốc không thành công!";
                return false;
            }
        }

        public DataTable TimKiemNhomThuoc(string tukhoanhom, string loainhom)
        {
            if (loainhom == "Mã nhóm thuốc")
            {
                query = $"SELECT * FROM dbo.NhomThuoc WHERE MaNhom LIKE N'%{tukhoanhom}%'";
            }    
            else if (loainhom == "Tên nhóm thuốc")
            {
                query = $"SELECT * FROM dbo.NhomThuoc WHERE TenNhom LIKE N'%{tukhoanhom}%'";
            }
            return _dataProvider.ExecuteQuery(query);
        }
    }
}
