using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppDemo.Startup))]
namespace MVCAppDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
