using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsPool.Startup))]
namespace SportsPool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
