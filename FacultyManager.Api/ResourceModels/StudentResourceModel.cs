using FacultyManager.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacultyManager.Api.ResourceModels
{
    public class StudentResourceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public int TeacherId { get; set; }
    }
}