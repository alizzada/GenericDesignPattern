using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.Domains
{
    public class Personal:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
