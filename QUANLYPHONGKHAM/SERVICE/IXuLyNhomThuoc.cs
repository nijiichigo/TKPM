using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.SERVICE
{
    public interface IXuLyNhomThuoc
    {
        DataTable TaiDanhSachNhomThuoc();
        bool KiemTraTonTaiMaNhomThuoc(string manhom);
        int KiemTraTonTaiNhomThuoc(string tennhom);
        bool ThemNhomThuoc(string tennhom, ref string thongbao);
        bool XoaNhomThuoc(string manhom, ref string thongbao);
        bool DieuChinhNhomThuoc(string manhom, string tennhom, ref string thongbao);
        DataTable TimKiemNhomThuoc(string tukhoanhom, string loainhom);
    }
}
