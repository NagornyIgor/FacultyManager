using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using FacultyManager.Api.ResourceModels;
using FacultyManager.Services.Services;

namespace FacultyManager.Api.Controllers
{
    public class TeacherController : ApiController
    {
        private readonly ITeacherService teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }

        public IHttpActionResult Get()
        {
            var teachers = Mapper.Map<IList<TeacherResourceModel>>(teacherService.GetAll());

            return Json(teachers);
        }
    }
}