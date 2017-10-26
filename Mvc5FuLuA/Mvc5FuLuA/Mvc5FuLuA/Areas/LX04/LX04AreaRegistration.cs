using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX04
{
    public class LX04AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LX04";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LX04_default",
                "LX04/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}