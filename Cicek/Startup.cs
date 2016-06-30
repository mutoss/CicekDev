using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cicek.Startup))]
namespace Cicek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
