using AutoMapper;
using FacultyManager.Api.ResourceModels;
using FacultyManager.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacultyManager.Api
{
    public class ResourceModelsMapperProfile : Profile
    {
        public ResourceModelsMapperProfile()
        {
            //CreateMap<IList<DepartmentDto>, DepartmentResourceModel>()
            //    .ForMember(dest => dest.Departments, opt => opt.MapFrom(source => source));

            //CreateMap<IList<StudentDto>, StudentResourceModel>()
            //    .ForMember(dest => dest.Students, opt => opt.MapFrom(source => source));

            //CreateMap<IList<TeacherDto>, TeacherResourceModel>()
            //    .ForMember(dest => dest.Teachers, opt => opt.MapFrom(source => source));

            CreateMap<DepartmentDto, DepartmentResourceModel>().PreserveReferences().ReverseMap();

            CreateMap<StudentDto, StudentResourceModel>().PreserveReferences().ReverseMap();

            CreateMap<TeacherDto, TeacherResourceModel>().PreserveReferences().ReverseMap();
        }
    }
}