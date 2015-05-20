using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseExplorer.Startup))]
namespace CourseExplorer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
