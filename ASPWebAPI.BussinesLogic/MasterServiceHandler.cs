using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPWebAPI.ViewModel;
using ASPWebAPI.Common;

namespace ASPWebAPI.BussinesLogic
{
    public class MasterServiceHandler : IMasterServiceHandler
    {
        private ICurrentUser CurrentUser { get; }
        private INetworkCredentialBuilder NetworkCredentialBuilder { get; }
        private ISpeedConsumer SpeedConsumer;
        private IInsightConsumer InsightConsumer;

        public MasterServiceHandler(ICurrentUser currentUser, INetworkCredentialBuilder networkCredentialBuilder,ISpeedConsumer speedConsumer,IInsightConsumer insightConsumer)
        {
            CurrentUser = currentUser;
            NetworkCredentialBuilder = networkCredentialBuilder;
            SpeedConsumer = speedConsumer;
            InsightConsumer = insightConsumer;
    }

        public IEnumerable<MilestoneVm> getMilestones()
        {
            var networkCredential = NetworkCredentialBuilder.BuildNetworkCretendial(CurrentUser.Usid);
            return InsightConsumer.getMilestones(networkCredential);
        }

        public IEnumerable<ProductVm> getProducts()
        {
            var networkCredential = NetworkCredentialBuilder.BuildNetworkCretendial(CurrentUser.Usid);
            return SpeedConsumer.getItemsById(networkCredential).Select(x => new ProductVm(x.Codigo, x.Nombre));
        }

        public IEnumerable<SteppingVm> getSteppings()
        {
            var networkCredential = NetworkCredentialBuilder.BuildNetworkCretendial(CurrentUser.Usid);
            return InsightConsumer.getSteppings(networkCredential);
        }
    }
}
