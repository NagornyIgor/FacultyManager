using FacultyManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Data.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        IList<Student> OrderByDepartment(int departmentId);
        IList<Student> OrderByCurator(int curatorId);
    }

    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext context)
            : base(context)
        {
        }

        public IList<Student> OrderByDepartment(int departmentId)
        {
            return context.Database.SqlQuery<Student>("[dbo].[StudentsOrderedByDepartment] @id", new SqlParameter("@id", departmentId)).ToList();
        }

        public IList<Student> OrderByCurator(int curatorId)
        {
            return context.Database.SqlQuery<Student>("[dbo].[StudentsOrderedByСurator] @id", new SqlParameter("id", curatorId)).ToList();
        }

    }
}
