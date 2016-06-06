using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDefault.Startup))]
namespace MVCDefault
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
