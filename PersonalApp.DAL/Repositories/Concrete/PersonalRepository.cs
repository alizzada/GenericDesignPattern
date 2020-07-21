using PersonalApp.DAL.Repositories.Abstract;
using PersonalApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.Repositories.Concrete
{
    public class PersonalRepository : Repository<Personal>, IPersonalRepository
    {
        public PersonalRepository(PersonalContext context):base(context)
        {

        }
        public IEnumerable<Personal> GetPersonalsWithDepartments()
        {
            return PersonalContext.Personals.Include("Department").ToList();
        }

        public PersonalContext PersonalContext { get { return _context as PersonalContext; } }
    }
}
