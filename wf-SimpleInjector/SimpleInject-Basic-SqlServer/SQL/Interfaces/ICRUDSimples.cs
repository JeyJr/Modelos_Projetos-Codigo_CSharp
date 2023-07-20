using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInject_Basic_SqlServer.SQL.Interfaces
{
    public interface ICRUDSimples
    {
        DataTable Select(string sql);
        int Delete(string sql);
        int Insert(string sql);
        int Update(string sql);
    }
}
