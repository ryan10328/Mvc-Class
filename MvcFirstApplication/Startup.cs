using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcFirstApplication.Startup))]
namespace MvcFirstApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
