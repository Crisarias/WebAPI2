using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.Common
{
    public interface ICurrentUser
    {
        string Usid { get; }
    }
}
