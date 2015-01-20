using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bulletin.Startup))]
namespace Bulletin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
