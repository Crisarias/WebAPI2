using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.Common
{
    public interface INetworkCredentialBuilder
    {
        NetworkCredential BuildNetworkCretendial(string usid);
    }
}
