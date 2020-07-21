using PersonalApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.Repositories.Abstract
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        IEnumerable<Department> GetTopDepartments(int count);
        IEnumerable<Department> GetDepartmentsWithPersonals();

    }
}
