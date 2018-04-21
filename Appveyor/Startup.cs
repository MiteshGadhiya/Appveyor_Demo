using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Appveyor.Startup))]
namespace Appveyor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
