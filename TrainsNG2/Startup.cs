using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainsNG2.Startup))]
namespace TrainsNG2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
