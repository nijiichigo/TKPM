using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.SERVICE
{
    public interface IXuLyDangKyKham
    {
        DataTable TaiDanhSachDangKyKham(string ngaykham);
        bool DangKyKham(string smabn, string ngaykham, ref string thongbao);
        bool HuyKham(string smabn, string ngaykham, ref string thongbao);
    }
}
