using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Noein.Startup))]
namespace Noein
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
