using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(awazon.Startup))]
namespace awazon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
