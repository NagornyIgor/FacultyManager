using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Data.Entity;
using FacultyManager.Data;
using System.Reflection;
using System.Linq;
using FacultyManager.Core.Services;
using SimpleInjector.Lifestyles;
using FacultyManager.Data.Models;

namespace FacultyManager.Api.App_Start
{
    public static class SimpleInjectorWebApiInitializer
    {
        static readonly Container container;

        static SimpleInjectorWebApiInitializer()
        {
            container = new Container();
        }

        public static void Initialize()
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Register<DbContext, FacultyDbContext>(Lifestyle.Scoped);
            container.Register<IDepartmentService, DepartmentService>(Lifestyle.Scoped);
            container.Register<IRepository<Department>, Repository<Department>>(Lifestyle.Scoped);
            //container.Register<IRepository<>, Repository<>>(Lifestyle.Scoped);
            //container.Register<IRepository<>, Repository<>>(Lifestyle.Scoped);


            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}