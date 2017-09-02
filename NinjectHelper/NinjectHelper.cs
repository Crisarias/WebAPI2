using ASPWebAPI.BussinesLogic;
using ASPWebAPI.Common;
using ASPWebAPI.Configuration;
using ASPWebAPI.RestApiConsumer;
using Ninject;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSWebAPI.NinjectHelper
{
    public class NinjectHelper
    {
        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        public static void RegisterCommonServices(IKernel kernel)
        {
            kernel.Bind<IConfiguration>().To<Configuration>().InRequestScope();
            kernel.Bind<ICurrentUser>().To<CurrentUser>().InRequestScope();
            kernel.Bind<INetworkCredentialBuilder>().To<NetworkCredentialBuilder>().InRequestScope();
            kernel.Bind<IRestAPIConsumer>().To<RestAPIConsumer>().InRequestScope();
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        public static void RegisterMasterDataServices(IKernel kernel)
        {
            kernel.Bind<IInsightConsumer>().To<InsightConsumer>().InRequestScope();
            kernel.Bind<ISpeedConsumer>().To<SpeedConsumer>().InRequestScope();
        }
    }
}
