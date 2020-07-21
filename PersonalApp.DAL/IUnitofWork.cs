using PersonalApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        IDepartmentRepository DepartmentRepository { get; }
        IPersonalRepository PersonalRepository { get; }
        int Complete();
    }
}
