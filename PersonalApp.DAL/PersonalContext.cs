using PersonalApp.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL
{
    public class PersonalContext:DbContext
    {
        public PersonalContext():base("PersonalContext")
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personal> Personals { get; set; }
    }
}
