using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CanIEatHereSpike.Startup))]
namespace CanIEatHereSpike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
