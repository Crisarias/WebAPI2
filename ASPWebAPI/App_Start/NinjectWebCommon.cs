[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ASPWebAPI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ASPWebAPI.App_Start.NinjectWebCommon), "Stop")]

namespace ASPWebAPI.App_Start
{
    using System;
    using System.Web;
    using ASPWebAPI.Configuration;
    using ASPWebAPI.Common;
    using ASPWebAPI.BussinesLogic;
    using ASPWebAPI.RestApiConsumer;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Controllers.MasterDataService;
    using Ninject.Web.WebApi;
    using System.Web.Http;
    using APSWebAPI.NinjectHelper;

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

                NinjectHelper.RegisterCommonServices(kernel);
                NinjectHelper.RegisterMasterDataServices(kernel);
                RegisterServices(kernel);
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }       

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IMasterServiceHandler>().To<MasterServiceHandler>().WhenInjectedExactlyInto<MasterDataController>().InRequestScope();
        }        
    }
}
