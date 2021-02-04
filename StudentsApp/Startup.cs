using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentsApp.Startup))]
namespace StudentsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
