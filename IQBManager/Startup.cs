using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IQBManager.Startup))]
namespace IQBManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
