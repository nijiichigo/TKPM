using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.SERVICE
{
    public interface IXuLyThuoc
    {
        DataTable TaiDanhSachThuoc();
        DataTable LietKeNhomThuoc();
        DataTable LietKeDonVi();
        bool ThemThuoc(string tenthuoc, string tennhomthuoc, string donvi, string dongia, ref string thongbao);
        bool DieuChinhThuoc(string mathuoc, string tenthuoc, string tennhomthuoc, string donvi, string dongia, ref string thongbao);
        bool XoaThuoc(string mathuoc, ref string thongbao);
        DataTable TimKiemThuoc(string tukhoa, string loai);
    }
}
