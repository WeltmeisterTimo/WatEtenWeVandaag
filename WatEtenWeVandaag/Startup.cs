using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WatEtenWeVandaag.Startup))]
namespace WatEtenWeVandaag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
