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
        bool ThemBenhNhan(string hoten, string namsinh, string gioitinh, string dienthoai, string diachi, ref string thongbao);

    }
}
