using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.Configuration
{
    public class Configuration : IConfiguration
    {
        private const string AppNameKey = "AppName";
        private const string BaseDatosKey = "BaseDatos";
        public string AppName
        {
            get
            {
               return ConfigurationManager.AppSettings[AppNameKey];
            }
        }

        public string BaseDatos
        {
            get
            {
               return ConfigurationManager.AppSettings[BaseDatosKey];
            }
        }
    }
}
