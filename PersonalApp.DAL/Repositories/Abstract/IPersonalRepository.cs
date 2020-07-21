using PersonalApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.Repositories.Abstract
{
    public interface IPersonalRepository:IRepository<Personal>
    {
        IEnumerable<Personal> GetPersonalsWithDepartments();
    }
}
