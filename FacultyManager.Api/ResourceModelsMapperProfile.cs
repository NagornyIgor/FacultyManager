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
            CreateMap<DepartmentDto, DepartmentResourceModel>().PreserveReferences().ReverseMap();

            CreateMap<StudentDto, StudentResourceModel>().PreserveReferences().ReverseMap();

            CreateMap<TeacherDto, TeacherResourceModel>().PreserveReferences().ReverseMap();
        }
    }
}