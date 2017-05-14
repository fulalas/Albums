using Albums.web.Repository;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Albums.web.App_Start
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IAlbumRepository>().To<AlbumRepository>();
            kernel.Bind<IPhotoRepository>().To<PhotoRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}