using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcApplicationJenkinsDemo.Startup))]
namespace MvcApplicationJenkinsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
