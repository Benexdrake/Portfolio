using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLLogin
{
    public interface IMySql
    {
        bool LoginDB(string sql);
        List<Actors> GetActors(string sql);
    }
}
