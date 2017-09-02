using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPWebAPI.Model;
using ASPWebAPI.ViewModel;
using System.Net;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace ASPWebAPI.RestApiConsumer
{
    public class RestAPIConsumer : IRestAPIConsumer
    {
        public IEnumerable<Speed> getItemsById(NetworkCredential credenciales)
        {
            return new List<Speed>() {
                new Speed() {Codigo="1",Descripcion="Desc art1",Nombre="art1" },
                new Speed() {Codigo="2",Descripcion="Desc art2",Nombre="art2" },
                new Speed() {Codigo="3",Descripcion="Desc art3",Nombre="art3" },
            };
        }

        public IEnumerable<MilestoneVm> getMilestones(NetworkCredential credenciales)
        {
            return new List<MilestoneVm>() {
                new MilestoneVm() {Codigo="1",Nombre="POP1",SteppingNm="Step1" },
                new MilestoneVm() {Codigo="2",Nombre="POP2",SteppingNm="Step2" },
                new MilestoneVm() {Codigo="3",Nombre="POP3",SteppingNm="Step3" },
                new MilestoneVm() {Codigo="3",Nombre="POP4",SteppingNm="Step1" },
            };
        }
    }
}
