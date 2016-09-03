using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCap4Modelos.Startup))]
namespace MvcCap4Modelos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
