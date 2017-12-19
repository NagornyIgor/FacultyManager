using AutoMapper;
using FacultyManager.Core.Dto;
using FacultyManager.Data;
using FacultyManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Core.Services
{
    public interface IDepartmentService
    {
        IList<DepartmentDto> GetAll();
    }

    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository<Department> departmentRepository;

        public DepartmentService(IRepository<Department> departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        public IList<DepartmentDto> GetAll()
        {
            var department = departmentRepository.GetAll();

            return Mapper.Map<IList<DepartmentDto>>(department);
        }

    }
}
