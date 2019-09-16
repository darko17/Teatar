using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teatar.Startup))]
namespace Teatar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
