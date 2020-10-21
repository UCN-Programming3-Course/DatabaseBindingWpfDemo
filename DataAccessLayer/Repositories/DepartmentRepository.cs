using Dapper;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    class DepartmentRepository : RepositoryBase, IRepository<Department>
    {
         public Department Create(Department entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
            using (var conn = GetConnection())
            {
                return conn.Query<Department>("SELECT * FROM Departments");
            }
        }

        public Department GetById(int id)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<Department>("SELECT * FROM Departments WHERE Id = @id", new { id }).SingleOrDefault();
            }
        }

        public Department Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
