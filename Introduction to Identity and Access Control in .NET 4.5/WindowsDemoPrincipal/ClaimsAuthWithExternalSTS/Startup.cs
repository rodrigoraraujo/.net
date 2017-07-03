using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClaimsAuthWithExternalSTS.Startup))]
namespace ClaimsAuthWithExternalSTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
