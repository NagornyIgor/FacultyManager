using AutoMapper;
using FacultyManager.Services.Dto;
using FacultyManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Services
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
