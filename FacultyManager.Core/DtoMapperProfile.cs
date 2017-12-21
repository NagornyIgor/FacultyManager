using AutoMapper;
using FacultyManager.Core.Dto;
using FacultyManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Core
{
    public class DtoMapperProfile : Profile
    {
        public DtoMapperProfile()
        {
            CreateMap<Department, DepartmentDto>().PreserveReferences().ReverseMap();

            CreateMap<Student, StudentDto>().PreserveReferences().ReverseMap();

            CreateMap<Teacher, TeacherDto>().PreserveReferences().ReverseMap();
        }
    }
}
