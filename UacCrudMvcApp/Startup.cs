using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UacCrudMvcApp.Startup))]
namespace UacCrudMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
