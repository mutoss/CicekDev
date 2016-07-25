using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cicek.Startup))]
namespace Cicek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //test 2.1
            //this is the dev version 2
            //first item for the release
            ConfigureAuth(app);
        }
    }
}
