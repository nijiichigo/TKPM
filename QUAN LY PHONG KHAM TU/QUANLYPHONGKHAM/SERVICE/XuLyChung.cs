using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYPHONGKHAM.DAL;

namespace QUANLYPHONGKHAM.SERVICE
{
    public class XuLyChung : IXuLyChung
    {
        private IDataProvider _dataProvider = new DataProvider();
        public int TaoSoThuTu(string query)
        {
            object omax = _dataProvider.ExecuteScalar(query);
            int result;
            if (int.TryParse(omax.ToString(), out int max))
            {
                result = max + 1;
            }
            else
            {
                result = 1;
            }
            return result;
        }
    }
}
