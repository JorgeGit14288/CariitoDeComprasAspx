using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarritoComprasAsp.Startup))]
namespace CarritoComprasAsp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
