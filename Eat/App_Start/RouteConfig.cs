using System.Web.Mvc;
using System.Web.Routing;

namespace Eat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Usually if we redirect to /Data/Index the router will make it just /Data instead because Index is the default action.
            // But /Data will fail because there's a folder called Data (see http://stackoverflow.com/questions/1437386/how-to-have-folder-and-controller-with-same-name-in-asp-net-mvc)
            // Do we create this specific route to make sure it gets hit correctly
            routes.MapRoute(
                name: "DataIndex",
                url: "Data/Index",
                defaults: new { controller = "Data", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
