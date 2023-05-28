﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAL
{
    public interface IDataProvider
    {
        DataTable ExecuteQuery(string query);
        int ExecuteNonQuery(string query);
        object ExecuteScalar(string query);
    }
}
