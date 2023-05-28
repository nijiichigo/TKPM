using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYPHONGKHAM.DAL;

namespace QUANLYPHONGKHAM.SERVICE
{
    public class XuLyChung : IXuLyChung
    {
        private IDataProvider _dataProvider = new DataProvider();
        
        public int TraMaSo(string query)
        {
            object omax = _dataProvider.ExecuteScalar(query);
            if (int.TryParse(omax.ToString(), out int result))
            {
                return result;
            }
            return -1;
        }

        public int TaoSoThuTu(string query)
        {
            object omax = _dataProvider.ExecuteScalar(query);
            if (int.TryParse(omax.ToString(), out int result))
            {
                return result + 1;
            }
            return 1;
        }

        public bool KiemTraTonTai(string query)
        {
            DataTable result = _dataProvider.ExecuteQuery(query);
            if (result.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

        public int StringToInt(string s)
        {
            if (int.TryParse(s, out int result))
            {
                return result;
            }
            else
            {
                return -1;
            }    
        }
    }
}
