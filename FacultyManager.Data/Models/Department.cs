using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentCode { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
