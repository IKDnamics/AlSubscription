using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Almal.Web.Startup))]
namespace Almal.Web
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}