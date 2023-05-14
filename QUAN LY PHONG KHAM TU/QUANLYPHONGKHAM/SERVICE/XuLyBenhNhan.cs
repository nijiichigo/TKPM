using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYPHONGKHAM.DAL;

namespace QUANLYPHONGKHAM.SERVICE
{
    public class XuLyBenhNhan : IXuLyBenhNhan
    {
        private IDataProvider _dataProvider = new DataProvider();
        private ILuuTru _luuTru = new LuuTru();

        public DataTable TaiDanhSachBenhNhan()
        {
            DataTable result = _luuTru.TaiDanhSach("*", "dbo.BenhNhan");
            return result;
        }

        public bool ThemBenhNhan(string hoten, string snamsinh, string gioitinh, string sdienthoai, string diachi, ref string thongbao)
        {
            string query = "SELECT MAX(MaBenhNhan) FROM dbo.BenhNhan";
            object max = _dataProvider.ExecuteScalar(query);

            int mabnmax, mabn, namsinh, dienthoai;
            if (int.TryParse(max.ToString(), out mabnmax))
            {
                mabn = mabnmax + 1;
            }
            else
            {
                mabn = 1;
            }

            if (!(int.TryParse(snamsinh, out namsinh)))
            {
                thongbao = "Năm sinh không hợp lệ!";
                return false;
            }
            else
            {
                namsinh = int.Parse(snamsinh);
            }

            if (!(int.TryParse(sdienthoai, out dienthoai)))
            {
                thongbao = "Số điện thoại không hợp lệ!";
                return false;
            }
            else
            {
                dienthoai = int.Parse(sdienthoai);
            }

            string query2 = $"INSERT dbo.BenhNhan (MaBenhNhan, HoTen, NamSinh, GioiTinh, DienThoai, DiaChi) VALUES ({mabn} , N'{hoten}' , {namsinh} , N'{gioitinh}' , {dienthoai} , N'{diachi}')";
            int result = _dataProvider.ExecuteNonQuery(query2);
            if (result > 0)
            {
                thongbao = "Thêm tài khoản thành công!";
                return true;
            }
            else
            {
                thongbao = "Thêm tài khoản không thành công!";
                return false;
            }
        }
    }
}
