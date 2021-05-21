using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(highchart_line.Startup))]
namespace highchart_line
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
