using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPWebAPI.Model;
using ASPWebAPI.Configuration;
using ASPWebAPI.RestApiConsumer;
using System.Net;

namespace ASPWebAPI.BussinesLogic
{
    public class SpeedConsumer : ISpeedConsumer
    {
        private IConfiguration Configuration { get; }
        private IRestAPIConsumer RestApiConsumer { get; }

        public SpeedConsumer(IConfiguration configuration,IRestAPIConsumer restApiConsumer)
        {
            Configuration = configuration;
            RestApiConsumer = restApiConsumer;
        }

        public IEnumerable<Speed> getItemsById(NetworkCredential credenciales)
        {            
            return RestApiConsumer.getItemsById(credenciales);
        }
    }
}
