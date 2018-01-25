using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoServiceTracking.Startup))]
namespace MoServiceTracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
