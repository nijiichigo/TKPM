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
        int TonTaiMaBenhNhan(string smabn, ref string thongbao);
        bool ThemBenhNhan(string hoten, string namsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao);
        bool DieuChinhBenhNhan(string smabn, string hoten, string snamsinh, string gioitinh, string sdienthoai, string diachi, ref string thongbao);
        bool XoaBenhNhan(string smabn, ref string thongbao);
        DataTable TimKiemBenhNhan(string tukhoa, string loai);
    }
}
