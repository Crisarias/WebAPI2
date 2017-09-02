using ASPWebAPI.Model;
using ASPWebAPI.ViewModel;
using System.Collections.Generic;
using System.Net;

namespace ASPWebAPI.RestApiConsumer
{
    public interface IRestAPIConsumer
    {
        IEnumerable<Speed> getItemsById(NetworkCredential credenciales);
        IEnumerable<MilestoneVm> getMilestones(NetworkCredential credenciales);
    }
}
