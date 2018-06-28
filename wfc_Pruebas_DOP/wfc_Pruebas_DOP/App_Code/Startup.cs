using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wfc_Pruebas_DOP.Startup))]
namespace wfc_Pruebas_DOP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
