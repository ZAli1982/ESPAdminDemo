using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using IET.Common.Interface;
using IET.ESP.Data.Repository;
using IET.ESP.Data.Repository.Interface;

namespace IET.ESP.Data
{
    public class DataRepositoryFactory : IDataRepositoryFactory, IDisposable
    {
        private  IWindsorContainer _container;

        public T GetDataRepository<T>() where T : IDataRepository
        {
            RepositoyContainer();
            return _container.Resolve<T>();
        }

        private void RepositoyContainer()
        {
            _container = new WindsorContainer();
            _container.Register(Component.For<IContentTypeRepository>()
                               .ImplementedBy<ContentTypeRepository>()
                               .LifestylePerWebRequest());

        }

        public void Dispose()
        {
            if (_container == null) return;
            _container.Dispose();
            _container = null;
        }
    }
}
