using ASPWebAPI.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.BussinesLogic
{
    public interface ISpeedConsumer
    {
        IEnumerable<Speed> getItemsById(NetworkCredential credenciales);
    }
}
