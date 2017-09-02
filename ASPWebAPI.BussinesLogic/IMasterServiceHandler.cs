using ASPWebAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.BussinesLogic
{
    public interface IMasterServiceHandler
    {
        IEnumerable<ProductVm> getProducts();
        IEnumerable<MilestoneVm> getMilestones();
        IEnumerable<SteppingVm> getSteppings();
    }
}
