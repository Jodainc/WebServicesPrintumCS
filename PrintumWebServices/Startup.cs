using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrintumWebServices.Startup))]
namespace PrintumWebServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
