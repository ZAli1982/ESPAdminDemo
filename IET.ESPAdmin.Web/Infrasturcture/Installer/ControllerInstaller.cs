using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using IET.ESP.Service.Interfaces;
using IET.ESPAdmin.Web.Controllers.Api;
using IET.ESP.Service;
using IET.Common.Interface;
using IET.ESP.Data;


namespace IET.ESPAdmin.Web.Infrasturcture.Installer
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // Register all the WebApi controllers within this assembly
            container.Register(Classes.FromAssembly(typeof(ContentTypesController).Assembly)
                              .BasedOn<ApiController>()
                              .LifestylePerWebRequest());

            container.Register(Component.For<IContentTypeService>()
                               .ImplementedBy<ContentTypeService>()
                               .LifestylePerWebRequest());

            //container.Register(Component.For<IContentTypeRepository>()
            //                   .ImplementedBy<ContentTypeRepository>()
            //                   .LifestylePerWebRequest());

            container.Register(Component.For<IDataRepositoryFactory>()
                               .ImplementedBy<DataRepositoryFactory>()
                               .LifestylePerWebRequest());
            
        }
    }
}