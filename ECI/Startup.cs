using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECI.Startup))]
namespace ECI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
