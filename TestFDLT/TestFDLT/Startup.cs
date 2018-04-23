using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestFDLT.Startup))]
namespace TestFDLT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
