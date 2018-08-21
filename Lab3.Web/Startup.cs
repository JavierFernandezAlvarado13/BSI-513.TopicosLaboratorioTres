using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3.Web.Startup))]
namespace Lab3.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
