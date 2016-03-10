using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestTest.Startup))]
namespace RestTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
