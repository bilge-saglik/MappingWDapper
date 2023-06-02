using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingWDapper
{
    public static class Init
    {
        public static void Init_()
        {
            DapperClass.SqlConnectionStringDB = File.ReadAllText(@"C:\ConnectionString.txt");
            DapperClass.SQLUpdateQuery = File.ReadAllText(@"C:\SQLUpdate.txt");
            DapperClass.SQLControlQuery = File.ReadAllText(@"C:\UniqueControlQuery.txt");
        }
    }
}