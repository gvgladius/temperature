using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace temperature
{
    /// <summary>
    /// Summary description for temperature
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class temperature : System.Web.Services.WebService
    {

        [WebMethod]
        public string tempcomp(int a)
        {
            if (a < 20)
                return "low";
            else if (a > 25)
                return "average";
            else
                return "high";
        }
    }
}
