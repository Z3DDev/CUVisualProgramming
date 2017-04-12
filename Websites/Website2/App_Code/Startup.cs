using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website2.Startup))]
namespace Website2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
