using System;
using System.IO;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyZico.DAL
{
    class sqlLiteBaseRepository
    {
        public sqlLiteBaseRepository()
        {

        }

        public static SqliteConnection DbConnectionFactory()
        {
            return new SqliteConnection(@"DataSource=SearchHistory.sqlite");
        }

        protected static bool DatabaseExist()
        {
            return File.Exists(@"SearchHistory.sqlite");
        }

        protected static void CreateDatabase()
        {
            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                connection.Execute(
                    @"CREATE TABLE History
                    (
                    Id                  INTEGER PRIMARY KEY AUTOINCREMENT,
                    ElementName         VARCHAR(255),
                    )");
            }
        }
    }
}
