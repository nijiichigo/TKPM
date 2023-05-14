using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAL
{
    public interface ILuuTru
    {
        DataTable TaiDanhSach(string select, string dbo);
    }
}
