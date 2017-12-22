using FacultyManager.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacultyManager.Api.ResourceModels
{
    public class DepartmentResourceModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int DepartmentCode { get; set; }
    }
}