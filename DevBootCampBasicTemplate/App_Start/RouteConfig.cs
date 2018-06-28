using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DevBootCampBasicTemplate
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            //throw exception during route config
<<<<<<< HEAD
           /* var connStr = $"server";
            if (ConfigurationManager.ConnectionStrings["myConnString"] == null)
            {
                connStr = $"Server=tcp:xxx.database.windows.net,1433;Initial Catalog=xxxx;Persist Security Info=False;User ID=xxx;Password=xxxx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=5;";
            }
            else
            {
                connStr = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;
            }

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();   ///TEST opening the connection to the web app 
            }
            */
=======
           /* */
>>>>>>> origin/master
        }
    }
}
