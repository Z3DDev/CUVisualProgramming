using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieDatabase.Startup))]
namespace MovieDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
