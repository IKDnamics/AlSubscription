using System.Web.Mvc;

namespace Almal.Web.Areas.Auth
{
    public class UsersAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Auth";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(null, "Login", new { controller = "Auth", action = "Login" });
            //context.MapRoute(null, "Logout", new { controller = "Auth", action = "Logout" });
          
        }
    }
}