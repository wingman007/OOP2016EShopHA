using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EShopHA.Startup))]
namespace EShopHA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
