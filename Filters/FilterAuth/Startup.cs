using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterAuth.Startup))]
namespace FilterAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
