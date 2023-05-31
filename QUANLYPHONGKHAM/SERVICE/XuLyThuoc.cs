using QUANLYPHONGKHAM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.SERVICE
{
    public class XuLyThuoc : IXuLyThuoc
    {
        private IDataProvider _dataProvider = new DataProvider();
        private IXuLyChung _xuLyChung = new XuLyChung();
        private IXuLyNhomThuoc _xuLyNhomThuoc = new XuLyNhomThuoc();
        private string query = string.Empty;

        public DataTable TaiDanhSachThuoc()
        {
            query = $"SELECT T.MaThuoc, T.TenThuoc, Nt.TenNhom, Dv.TenDonVi, T.DonGia " +
                $"FROM dbo.NhomThuoc AS Nt JOIN dbo.Thuoc AS T ON T.MaNhom = Nt.MaNhom " +
                $"JOIN dbo.DonVi AS Dv ON T.MaDonVi = Dv.MaDonVi";
            return _dataProvider.ExecuteQuery(query);
        }

        public DataTable LietKeNhomThuoc()
        {
            query = $"SELECT TenNhom FROM dbo.NhomThuoc";
            return _dataProvider.ExecuteQuery(query);
        }

        public DataTable LietKeDonVi()
        {
            query = $"SELECT TenDonVi FROM dbo.DonVi";
            return _dataProvider.ExecuteQuery(query);
        }

        public int KiemTraTonTaiMaThuoc(string mathuoc)
        {
            if (_xuLyChung.StringToInt(mathuoc) >= 0)
            {
                query = $"SELECT * FROM dbo.Thuoc WHERE MaThuoc = {mathuoc}";
                if (_xuLyChung.KiemTraTonTai(query))
                {
                    return int.Parse(mathuoc);
                }
            }
            return -1;
        }

        public int KiemTraTonTaiDonVi(string donvi)
        {
            query = $"SELECT MaDonVi FROM dbo.DonVi WHERE TenDonVi = N'{donvi}'";
            if (_xuLyChung.KiemTraTonTai(query))
            {
                return _xuLyChung.TraMaSo(query);
            }
            return -1;
        }

        public int KiemTraTonTaiTenThuoc(string tenthuoc)
        {
            query = $"SELECT MaThuoc FROM dbo.Thuoc WHERE TenThuoc = N'{tenthuoc}'";
            if (_xuLyChung.KiemTraTonTai(query))
            {
                return _xuLyChung.TraMaSo(query);
            }
            return -1;
        }

        public bool KiemTraThongTinThuoc(string mathuoc, string tenthuoc, string tennhomthuoc, string donvi, string dongia, ref string thongbao)
        {
            if ((tenthuoc == "") || (tennhomthuoc == "") || (donvi == "") || (dongia == ""))
            {
                thongbao = "Vui lòng điền đầy đủ thông tin!";
                return false;
            }
            if ((KiemTraTonTaiTenThuoc(tenthuoc) > 0) && (KiemTraTonTaiTenThuoc(tenthuoc) != int.Parse(mathuoc)))
            {
                thongbao = $"Tên thuốc {tenthuoc} đã tồn tại!";
                return false;
            }
            if (_xuLyNhomThuoc.KiemTraTonTaiNhomThuoc(tennhomthuoc) < 0)
            {
                thongbao = $"Tên phân loại nhóm {tennhomthuoc} không tồn tại!";
                return false;
            }
            if (KiemTraTonTaiDonVi(donvi) < 0)
            {
                thongbao = $"Đơn vị {donvi} không tồn tại!";
                return false;
            }
            if (_xuLyChung.StringToInt(dongia) <= 0)
            {
                thongbao = $"Đơn giá không hợp lệ!";
                return false;
            }
            return true;
        }

        public bool ThemThuoc(string tenthuoc, string tennhomthuoc, string donvi, string dongia , ref string thongbao)
        {
            if (KiemTraThongTinThuoc("-1", tenthuoc, tennhomthuoc, donvi, dongia, ref thongbao))
            {
                query = $"SELECT MAX(MaThuoc) FROM dbo.Thuoc";
                int mathuoc = _xuLyChung.TaoSoThuTu(query);
                int manhom = _xuLyNhomThuoc.KiemTraTonTaiNhomThuoc(tennhomthuoc);
                int madv = KiemTraTonTaiDonVi(donvi);

                query = $"INSERT dbo.Thuoc (MaThuoc, TenThuoc, MaNhom, MaDonVi, DonGia) " +
                    $"VALUES ({mathuoc} , N'{tenthuoc}' , {manhom} , {madv} , {dongia})";
                int result = _dataProvider.ExecuteNonQuery(query);
                if (result > 0)
                {
                    thongbao = "Thêm thuốc thành công!";
                    return true;
                }
                else
                {
                    thongbao = "Thêm thuốc không thành công!";
                    return false;
                }
            }
            return false;
        }

        public bool DieuChinhThuoc(string mathuoc, string tenthuoc, string tennhomthuoc, string donvi, string dongia, ref string thongbao)
        {
            if (KiemTraTonTaiMaThuoc(mathuoc) < 0)
            {
                thongbao = $"Mã thuốc {mathuoc} không tồn tại!";
                return false;
            }
            if (KiemTraThongTinThuoc(mathuoc, tenthuoc, tennhomthuoc, donvi, dongia, ref thongbao))
            {
                int manhom = _xuLyNhomThuoc.KiemTraTonTaiNhomThuoc(tennhomthuoc);
                int madv = KiemTraTonTaiDonVi(donvi);
                query = $"UPDATE dbo.Thuoc SET TenThuoc = N'{tenthuoc}' , MaNhom = {manhom} , MaDonVi = {madv} , DonGia = {dongia} WHERE MaThuoc = {mathuoc}";
                int result = _dataProvider.ExecuteNonQuery(query);
                if (result > 0)
                {
                    thongbao = "Cập nhật thuốc thành công!";
                    return true;
                }
                else
                {
                    thongbao = "Cập nhật thuốc không thành công!";
                    return false;
                }
            }
            return false;
        }

        public bool XoaThuoc(string mathuoc, ref string thongbao)
        {
            if (mathuoc == "")
            {
                thongbao = "Vui lòng điền mã thuốc!";
                return false;
            }
            if (KiemTraTonTaiMaThuoc(mathuoc) < 0)
            {
                thongbao = $"Mã thuốc {mathuoc} không tồn tại!";
                return false;
            }

            query = $"DELETE FROM dbo.Thuoc WHERE MaThuoc = {mathuoc}";
            int result = _dataProvider.ExecuteNonQuery(query);
            if (result > 0)
            {
                thongbao = "Xóa thuốc thành công!";
                return true;
            }
            else
            {
                thongbao = "Xóa không thành công!";
                return false;
            }
        }

        public DataTable TimKiemThuoc(string tukhoa, string loai)
        {
            if (loai == "Mã thuốc")
            {
                query = $"SELECT * FROM dbo.Thuoc WHERE MaThuoc LIKE N'%{tukhoa}%'";
            }
            else if (loai == "Tên thuốc")
            {
                query = $"SELECT * FROM dbo.Thuoc WHERE TenThuoc LIKE N'%{tukhoa}%'";
            }
            else if (loai == "Mã nhóm thuốc")
            {
                query = $"SELECT * FROM dbo.Thuoc WHERE MaNhom LIKE N'%{tukhoa}%'";
            }    
            return _dataProvider.ExecuteQuery(query);
        }
    }
}
