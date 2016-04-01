using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BugGuardian.WebForms.TestWebApp.Startup))]
namespace BugGuardian.WebForms.TestWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
