using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestRepo2.Startup))]
namespace TestRepo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
