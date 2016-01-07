using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApiCastleIntegration.Infrastructure;

namespace IET.ESPAdmin.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private static IWindsorContainer _container;

        protected void Application_Start()
        {
            //System.Diagnostics.Debugger.Break();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BootstrapContainer();
        }

        private static void BootstrapContainer()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());

            // Configure WebApi to use a new CastleDependencyResolver as its dependency resolver
            GlobalConfiguration.Configuration.DependencyResolver = new CastleDependencyResolver(_container);

            //_container.Install(FromAssembly.Containing<DataZoneSubContractorService>());
            //var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            //ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        protected void Application_End()
        {
            _container.Dispose();
        }
    }
}
