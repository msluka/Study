using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportShop.Startup))]
namespace SportShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
