using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrystalWithVisual.Startup))]
namespace CrystalWithVisual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
