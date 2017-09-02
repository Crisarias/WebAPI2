using ASPWebAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.BussinesLogic
{
    public interface IInsightConsumer
    {
        IEnumerable<MilestoneVm> getMilestones(NetworkCredential credenciales);
        IEnumerable<SteppingVm> getSteppings(NetworkCredential credenciales);
    }
}
