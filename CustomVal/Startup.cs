using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomVal.Startup))]
namespace CustomVal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
