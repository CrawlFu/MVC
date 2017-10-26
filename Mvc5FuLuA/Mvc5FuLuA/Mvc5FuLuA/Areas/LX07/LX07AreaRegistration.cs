using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX07
{
    public class LX07AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LX07";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LX07_default",
                "LX07/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}