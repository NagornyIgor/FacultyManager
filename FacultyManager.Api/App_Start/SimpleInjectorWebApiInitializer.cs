using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Data.Entity;
using FacultyManager.Data;
using System.Reflection;
using System.Linq;
using FacultyManager.Services.Services;
using SimpleInjector.Lifestyles;
using FacultyManager.Data.Models;
using FacultyManager.Data.Repositories;

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

            //Services
            container.Register<IDepartmentService, DepartmentService>(Lifestyle.Scoped);
            container.Register<IStudentService, StudentService>(Lifestyle.Scoped);
            container.Register<ITeacherService, TeacherService>(Lifestyle.Scoped);

            //Repositories
            container.Register<IRepository<Department>, Repository<Department>>(Lifestyle.Scoped);
            container.Register<IRepository<Teacher>, Repository<Teacher>>(Lifestyle.Scoped);
            container.Register<IStudentRepository, StudentRepository>(Lifestyle.Scoped);


            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}