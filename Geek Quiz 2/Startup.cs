using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Geek_Quiz_2.Startup))]
namespace Geek_Quiz_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
