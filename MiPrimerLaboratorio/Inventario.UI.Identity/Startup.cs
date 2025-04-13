using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inventario.UI.Identity.Startup))]
namespace Inventario.UI.Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
