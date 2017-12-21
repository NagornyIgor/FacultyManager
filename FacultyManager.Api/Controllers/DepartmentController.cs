using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using FacultyManager.Api.ResourceModels;
using FacultyManager.Core.Services;

namespace FacultyManager.Api.Controllers
{
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        // GET api/department
        public IHttpActionResult Get()
        {
            var departments = departmentService.GetAll();

            var resource = Mapper.Map<IList<DepartmentResourceModel>>(departments);

            return Json(resource);
        }
    }
}
