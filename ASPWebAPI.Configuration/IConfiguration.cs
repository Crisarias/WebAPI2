using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.Configuration
{
    public interface IConfiguration
    {
        string BaseDatos { get; }
        string AppName { get; }
    }
}
