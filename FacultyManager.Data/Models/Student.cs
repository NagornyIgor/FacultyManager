using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}
