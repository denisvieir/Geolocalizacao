using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeoLocalization.Startup))]
namespace GeoLocalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
