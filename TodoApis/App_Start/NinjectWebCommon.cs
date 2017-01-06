[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TodoApis.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(TodoApis.App_Start.NinjectWebCommon), "Stop")]

namespace TodoApis.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using TodoApis.Models;
    using TodoApis.IRepositories;
    using TodoApis.IServices;
    using TodoApis.Repositories;
    using TodoApis.Services;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterContext(kernel);
                RegisterRepositories(kernel);
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Register Context
        /// </summary>
        /// <param name="kernel">The kernel</param>
        private static void RegisterContext(IKernel kernel)
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            kernel.Bind<IderaCWFRepositoryEntities2>().ToSelf().InRequestScope();
        }

        /// <summary>
        /// Register Repositories
        /// </summary>
        /// <param name="kernel">Kernel</param>
        private static void RegisterRepositories(IKernel kernel)
        {
            kernel.Bind<IRoleRepository>().To<RoleRepository>().InRequestScope();
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IRoleService>().To<RoleService>().InRequestScope();
        }        
    }
}
