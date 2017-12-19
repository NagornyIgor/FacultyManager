using FacultyManager.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacultyManager.Api.ResourceModels
{
    public class DepartmentResourceModel
    {
        public IList<DepartmentDto> Departments { get; set; }
    }
}