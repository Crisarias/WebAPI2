using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ASPWebAPI.Common
{
    public class CurrentUser : ICurrentUser
    {
        public string Usid
        {
            get
            {
                return HttpContext.Current.User.Identity.Name;
            }
        }
    }
}
