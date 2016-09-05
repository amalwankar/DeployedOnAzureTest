using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeployedOnAzureTest.Startup))]
namespace DeployedOnAzureTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
