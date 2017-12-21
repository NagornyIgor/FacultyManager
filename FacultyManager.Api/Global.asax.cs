using AutoMapper;
using FacultyManager.Api.App_Start;
using FacultyManager.Services;
using FacultyManager.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FacultyManager.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            SimpleInjectorWebApiInitializer.Initialize();

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ResourceModelsMapperProfile>();
                cfg.AddProfile<DtoMapperProfile>();
            });
        }
    }
}
