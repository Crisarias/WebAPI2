using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.Common
{
    public class NetworkCredentialBuilder : INetworkCredentialBuilder
    {
        public NetworkCredential BuildNetworkCretendial(string usid)
        {
            return new NetworkCredential(usid,"criacha9889");
        }
    }
}
