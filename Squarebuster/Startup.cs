using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Squarebuster.Startup))]
namespace Squarebuster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
