using FacultyManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Data
{
    public class FacultyDbInitializer : CreateDatabaseIfNotExists<FacultyDbContext>
    {
        protected override void Seed(FacultyDbContext context)
        {
            IList<Department> defaultDepartments = new List<Department>();

            defaultDepartments.Add(new Department() { DepartmentCode = 101, Name = "Кафедра финансов" });
            defaultDepartments.Add(new Department() { DepartmentCode = 102, Name = "Кафедра математики" });
            defaultDepartments.Add(new Department() { DepartmentCode = 103, Name = "Кафедра физики" });

            IList<Student> dafaultStudents = new List<Student>();

            IList<Teacher> defaultTeachers = new List<Teacher>();

            foreach (var department in defaultDepartments)
            {
                context.Departments.Add(department);
            }

            base.Seed(context);
        }
    }
}
