using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoDiscos.Startup))]
namespace ProyectoDiscos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
