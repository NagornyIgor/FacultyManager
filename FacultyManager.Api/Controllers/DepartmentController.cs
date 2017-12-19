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
            //var resource = Mapper.Map<DepartmentResourceModel>(departmentService.GetAll());
            var resource = departmentService.GetAll();

            return Json(resource);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
