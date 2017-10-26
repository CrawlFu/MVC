using System.Web.Mvc;

namespace Mvc5FuLuA.Areas.LX05
{
    public class LX05AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LX05";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LX05_default",
                "LX05/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}