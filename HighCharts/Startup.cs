using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HighCharts.Startup))]
namespace HighCharts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
