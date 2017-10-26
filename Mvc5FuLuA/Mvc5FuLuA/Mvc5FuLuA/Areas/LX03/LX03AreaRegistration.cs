using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX03
{
    public class LX03AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LX03";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LX03_default",
                "LX03/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}