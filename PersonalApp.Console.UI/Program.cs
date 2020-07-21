using PersonalApp.DAL;
using PersonalApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonalContext());
            unitOfWork.DepartmentRepository.Add(new Department { Name = "Finance", IsActive = true, CreateDate = DateTime.Now });
            unitOfWork.Complete();

        }
    }
}
