using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Beach.Startup))]
namespace Beach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
