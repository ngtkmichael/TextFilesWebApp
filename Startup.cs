using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TextFilesWebApp.Startup))]
namespace TextFilesWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
