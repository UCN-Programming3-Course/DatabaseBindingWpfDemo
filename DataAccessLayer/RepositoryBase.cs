using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal abstract class RepositoryBase
    {
        private readonly string _connectionString = "Data Source=(localdb)\\mssqllocaldb; Initial Catalog=EmployeeDb; Integrated Security=true";

        protected IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
