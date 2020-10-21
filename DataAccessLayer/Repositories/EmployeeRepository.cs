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
    class EmployeeRepository : RepositoryBase, IRepository<Employee>
    {
        public Employee Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var conn = GetConnection())
            {
                return conn.Query<Employee, Department, Employee>("SELECT * FROM Employees JOIN Departments ON Employees.DepartmentId = Departments.Id", (e, d) =>
                {
                    e.Department = d;
                    return e;
                });
            }
        }

        public Employee Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
