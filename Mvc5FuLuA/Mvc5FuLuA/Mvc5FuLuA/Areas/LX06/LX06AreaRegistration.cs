using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX06
{
    public class LX06AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LX06";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LX06_default",
                "LX06/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}