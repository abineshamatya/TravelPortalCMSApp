using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TravelPortalCMSApp.Models;

[assembly: OwinStartupAttribute(typeof(TravelPortalCMSApp.Startup))]
namespace TravelPortalCMSApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //addRolesandUsers();
        }

       
    }
}
