using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAL
{
    public class LuuTru : ILuuTru
    {
        private IDataProvider _dataProvider = new DataProvider();
        public DataTable TaiDanhSach(string select, string dbo)
        {
            string query = "SELECT " + select + " FROM " + dbo;
            DataTable result = _dataProvider.ExecuteQuery(query);
            return result;
        }
    }
}
