using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class RepositoryFactory<TEntity>
    {
        public static IRepository<TEntity> Create()
        {
            switch (typeof(TEntity).Name)
            {
                case "Department":
                    return new DepartmentRepository() as IRepository<TEntity>;
                case "Employee":
                    return new EmployeeRepository() as IRepository<TEntity>;
                default:
                    throw new Exception($"Unknown type: [{typeof(TEntity).Name}]");
            }
        }
    }
}
