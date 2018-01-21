using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mck.Startup))]
namespace mck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
