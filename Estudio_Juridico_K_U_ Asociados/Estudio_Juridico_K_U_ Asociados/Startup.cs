using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Estudio_Juridico_K_U__Asociados.Startup))]
namespace Estudio_Juridico_K_U__Asociados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
