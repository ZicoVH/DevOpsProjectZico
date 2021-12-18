using System;
using Dapper;
using CaseStudyZico.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyZico.DAL
{
    class AtomRepository : sqlLiteBaseRepository
    {

        public AtomRepository()
        {
            if (!DatabaseExist())
            {
                CreateDatabase();
            }
        }


        public int InsertName(AddElement addElement)
        {
            string sql = "INSERT INTO History (ElementName) Values (@ElementName);";
            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql, addElement);
            }
        }

        public int DeleteElement(string elementname)
        {
            string sql = "DELETE FROM History WHERE ElementName = @ElementName;";
            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql, new { ElementName = elementname });
            }
        }

        public int ClearAll()
        {
            string sql = "Delete FROM History;";
            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql);
            }
        }

        public IEnumerable<AddElement> GetSearchHistory()
        {
            string sql = "SELECT * FROM History;";
            using (var connection = DbConnectionFactory())
            {
                return connection.Query<AddElement>(sql);
            }
        }
    }
}
