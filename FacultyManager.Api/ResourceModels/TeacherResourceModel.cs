using FacultyManager.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacultyManager.Api.ResourceModels
{
    public class TeacherResourceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Rank { get; set; }
        public string Сourse { get; set; }
    }
}