using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PapillonDesignsApplication.Startup))]
namespace PapillonDesignsApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
