using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ProductSearchEngine.Web
{
    public class Global : System.Web.HttpApplication
    {
        public static int count = 0;
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Count"] = count;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            count = Convert.ToInt32(Application["Count"]);
            Application["Count"] = count + 1;
            new ProductSearchEngine.Business.Adapters.WebTrackerAdapter().AddTracking(DateTime.Now, Request.ServerVariables["REMOTE_ADDR"], Request.ServerVariables["HTTP_USER_AGENT"]);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}