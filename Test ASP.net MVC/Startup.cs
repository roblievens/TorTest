using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_ASP.net_MVC.Startup))]
namespace Test_ASP.net_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
