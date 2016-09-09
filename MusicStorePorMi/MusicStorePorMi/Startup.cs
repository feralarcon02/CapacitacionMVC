using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStorePorMi.Startup))]
namespace MusicStorePorMi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
