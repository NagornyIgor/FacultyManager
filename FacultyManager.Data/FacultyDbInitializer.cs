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
            //Set Departments table data
            IList<Department> departments = new[] {
                new Department() { DepartmentCode = 101, Name = "Department of Finance" },
                new Department() { DepartmentCode = 102, Name = "Department of Math" },
                new Department() { DepartmentCode = 103, Name = "Department of Physics" }
            };

            //departments.Add(new Department() { DepartmentCode = 101, Name = "Department of Finance" });
            //departments.Add(new Department() { DepartmentCode = 102, Name = "Department of Math" });
            //departments.Add(new Department() { DepartmentCode = 103, Name = "Department of Physics" });


            //Set Students table data
            IList<Student> students = new[] {
                new Student() { Age = 15, Name = "Noah", Surname = "Smith" },
                new Student() { Age = 15, Name = "Liam", Surname = "Johnson" },
                new Student() { Age = 15, Name = "Mason", Surname = "Williams" },
                new Student() { Age = 15, Name = "Jacob", Surname = "Jones" },
                new Student() { Age = 15, Name = "William", Surname = "Brown" },
                new Student() { Age = 15, Name = "Ethan", Surname = "Davis " },
                new Student() { Age = 15, Name = "James", Surname = "Miller" },
                new Student() { Age = 15, Name = "Alexander", Surname = "Wilson" }
            };

            //students.Add(new Student() { Age = 15, Name = "Noah", Surname = "Smith" });
            //students.Add(new Student() { Age = 15, Name = "Liam", Surname = "Johnson" });
            //students.Add(new Student() { Age = 15, Name = "Mason", Surname = "Williams" });
            //students.Add(new Student() { Age = 15, Name = "Jacob", Surname = "Jones" });
            //students.Add(new Student() { Age = 15, Name = "William", Surname = "Brown" });
            //students.Add(new Student() { Age = 15, Name = "Ethan", Surname = "Davis " });
            //students.Add(new Student() { Age = 15, Name = "James", Surname = "Miller" });
            //students.Add(new Student() { Age = 15, Name = "Alexander", Surname = "Wilson" });

            //Set Teachers table data
            IList<Teacher> teachers = new[] {
                new Teacher() { Name = "Michael", Surname = "Moore", Rank = "Teacher", Сourse = "Science" },
                new Teacher() { Name = "Benjamin", Surname = "Taylor", Rank = "Teacher", Сourse = "Mathematics" },
                new Teacher() { Name = "Elijah", Surname = "Anderson", Rank = "Docent", Сourse = "Art" },
                new Teacher() { Name = "Daniel", Surname = "Thomas", Rank = "Docent", Сourse = "Astronomy" },
                new Teacher() { Name = "Aiden", Surname = "Jackson", Rank = "Teacher", Сourse = "Journalism" },
                new Teacher() { Name = "Logan", Surname = "White", Rank = "Professor", Сourse = "Geology" }
            };

            //teachers.Add(new Teacher() { Name = "Michael", Surname = "Moore", Rank = "Teacher", Сourse = "Science" });
            //teachers.Add(new Teacher() { Name = "Benjamin", Surname = "Taylor", Rank = "Teacher", Сourse = "Mathematics" });
            //teachers.Add(new Teacher() { Name = "Elijah", Surname = "Anderson", Rank = "Docent", Сourse = "Art" });
            //teachers.Add(new Teacher() { Name = "Daniel", Surname = "Thomas", Rank = "Docent", Сourse = "Astronomy" });
            //teachers.Add(new Teacher() { Name = "Aiden", Surname = "Jackson", Rank = "Teacher", Сourse = "Journalism" });
            //teachers.Add(new Teacher() { Name = "Logan", Surname = "White", Rank = "Professor", Сourse = "Geology" });
            

            //Set Department_Id in Students table
            departments[0].Students = new[] { students[0], students[1], students[2] };
            departments[1].Students = new[] { students[3], students[4], students[5] };
            departments[2].Students = new[] { students[6], students[7] };

            //Set Department_Id in Teachers table
            departments[0].Teachers = new[] { teachers[0], teachers[1] };
            departments[1].Teachers = new[] { teachers[2], teachers[3] };
            departments[2].Teachers = new[] { teachers[4], teachers[5] };

            //Set Teacher_Id in Students table
            teachers[0].Students = new[] { students[0] };
            teachers[1].Students = new[] { students[1] };
            teachers[2].Students = new[] { students[2] };
            teachers[3].Students = new[] { students[3] };
            teachers[4].Students = new[] { students[4], students[6] };
            teachers[5].Students = new[] { students[5], students[7] };          

            foreach (var department in departments)
            {
                context.Departments.Add(department);
            }

            foreach (var student in students)
            {
                context.Students.Add(student);
            }

            foreach (var teacher in teachers)
            {
                context.Teachers.Add(teacher);
            }

            base.Seed(context);
        }
    }
}
