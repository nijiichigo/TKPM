using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.SERVICE
{
    public interface IXuLyChung
    {
        int TraMaSo(string query);
        int TaoSoThuTu(string query);
        string LayChuoi(string query);
        bool KiemTraTonTai(string query);
        int StringToInt(string s);
    }
}
