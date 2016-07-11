using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(arihant.Startup))]
namespace arihant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
