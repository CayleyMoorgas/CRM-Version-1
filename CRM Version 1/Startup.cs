using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRM_Version_1.Startup))]
namespace CRM_Version_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
