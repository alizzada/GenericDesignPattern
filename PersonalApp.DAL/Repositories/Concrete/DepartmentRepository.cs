using PersonalApp.DAL.Repositories.Abstract;
using PersonalApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonalContext context):base(context)
        {

        }
        public IEnumerable<Department> GetDepartmentsWithPersonals()
        {
            return PersonalContext.Departments.Include("Personal").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonalContext.Departments.Take(count);
        }

        public PersonalContext PersonalContext { get { return _context as PersonalContext; } }
    }
}
