using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Truextend.AdmStudent.UI.Web.Startup))]
namespace Truextend.AdmStudent.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
