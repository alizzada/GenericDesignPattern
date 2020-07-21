using PersonalApp.DAL.Repositories.Abstract;
using PersonalApp.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonalContext _personalContext;
        public UnitOfWork(PersonalContext context)
        {
            _personalContext = context;
            DepartmentRepository = new DepartmentRepository(_personalContext);
            PersonalRepository = new PersonalRepository(_personalContext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonalRepository PersonalRepository { get; private set; }

        public int Complete()
        {
            return _personalContext.SaveChanges();
        }

        public void Dispose()
        {
            _personalContext.Dispose();
        }
    }
}
