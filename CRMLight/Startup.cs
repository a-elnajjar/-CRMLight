using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRMLight.Startup))]
namespace CRMLight
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
