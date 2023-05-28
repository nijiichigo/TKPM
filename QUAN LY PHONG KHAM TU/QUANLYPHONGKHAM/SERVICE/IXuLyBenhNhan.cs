using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.SERVICE
{
    public interface IXuLyBenhNhan
    {
        DataTable TaiDanhSachBenhNhan();
        bool KiemTraTonTaiMaBenhNhan(string mabn);
        bool ThemBenhNhan(string hoten, string namsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao);
        bool XoaBenhNhan(string mabn, ref string thongbao);
        bool DieuChinhBenhNhan(string mabn, string hoten, string namsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao);
        DataTable TimKiemBenhNhan(string tukhoa, string loai);
    }
}
