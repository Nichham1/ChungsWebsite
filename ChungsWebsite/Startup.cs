using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChungsWebsite.Startup))]
namespace ChungsWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
