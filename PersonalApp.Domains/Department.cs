using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.Domains
{
    public class Department:BaseEntity
    {
        public Department()
        {
            Personals = new List<Personal>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Personal> Personals { get; set; }

    }
}
