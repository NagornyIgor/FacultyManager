using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using FacultyManager.Api.ResourceModels;
using FacultyManager.Services.Dto;
using FacultyManager.Services.Services;

namespace FacultyManager.Api.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet, ActionName("Get")]
        public IHttpActionResult Get()
        {
            var students = Mapper.Map<IList<StudentResourceModel>>(studentService.GetAll());

            return Json(students);
        }

        [HttpGet, ActionName("OrderByCurator")]
        public IHttpActionResult OrderByCurator(int id)
        {
            var students = studentService.OrderByCurator(id);

            return Json(students);
        }

        [HttpGet, ActionName("OrderByDepartment")]
        public IHttpActionResult OrderByDepartment(int id)
        {
            var students = studentService.OrderByDepartment(id);

            return Json(students);
        }

        public HttpResponseMessage Add(StudentResourceModel newStudent)
        {
            var newStudentDto = Mapper.Map<StudentDto>(newStudent);

            studentService.CreateStudent(newStudentDto);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}