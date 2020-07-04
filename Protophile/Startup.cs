using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Protophile.Startup))]
namespace Protophile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
