using Microsoft.Owin;
using Owin;
using Microsoft.AspNetCore.Http;
using React.AspNet;

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
