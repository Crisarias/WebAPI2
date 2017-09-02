using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ASPWebAPI.ViewModel;
using ASPWebAPI.Configuration;
using ASPWebAPI.RestApiConsumer;

namespace ASPWebAPI.BussinesLogic
{
    public class InsightConsumer : IInsightConsumer
    {
        private IConfiguration Configuration { get; }
        private IRestAPIConsumer RestApiConsumer { get; }

        public InsightConsumer(IConfiguration configuration, IRestAPIConsumer restApiConsumer)
        {
            Configuration = configuration;
            RestApiConsumer = restApiConsumer;
        }

        public IEnumerable<MilestoneVm> getMilestones(NetworkCredential credenciales)
        {
            return RestApiConsumer.getMilestones(credenciales);
        }

        public IEnumerable<SteppingVm> getSteppings(NetworkCredential credenciales)
        {
            var milestones =  RestApiConsumer.getMilestones(credenciales);
            return milestones.Select(x => x.SteppingNm).Distinct().Select(x => new SteppingVm() { Codigo = x, Nombre = x });
        }
    }
}
