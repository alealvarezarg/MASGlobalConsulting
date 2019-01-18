using MASGlobal.BLL.Classes;
using MASGlobal.DAL.Classes;
using MASGlobal.Domain.Interface;
using MASGlobal.Models;
using System.Web.Http;
using Unity;

namespace MASGlobal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IEmployeeBLLRepository, EmployeeBLLRepository>();
            container.RegisterType<IEmployeeDALRepository, EmployeeDALRepository>();
            container.RegisterType<IEmployeeFactory, EmployeeFactory>();
            config.DependencyResolver = new MASGlobalDPIResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
