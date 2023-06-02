using System;
using Dapper;
using System.IO;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace MappingWDapper
{
    public static class DapperClass
    {
        public static string SqlConnectionStringDB = "";
        public static string SQLUpdateQuery = "";
        public static string SQLControlQuery = "";

        public static List<listName> ReadAll()
        {
            List<listName> write = new List<listName>();
            using (var con = new SqlConnection(SqlConnectionStringDB))
            {

                write = con.Query<listName>
                    ("SELECT * FROM [DBname].[dbo].[TableName]").ToList();
            }
            return write;
        }

        public static int Insert(listName liststringName)
        {
            using (var con = new SqlConnection(SqlConnectionStringDB))
            {
                string xSql = "";
                xSql += "insert query";
                int affectedRows = con.Execute(xSql, liststringName);
                return affectedRows;
            }
        }
        public static int Control1(listName liststringName)
        {
            using (var con = new SqlConnection(SqlConnectionStringDB))
            {
                string Query = SQLControlQuery;
                var v = con.Query(Query, liststringName);

                return v.Count();
            }
        }


    }

}