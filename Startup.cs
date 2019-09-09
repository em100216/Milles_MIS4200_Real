using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Milles_MIS4200_Real.Startup))]
namespace Milles_MIS4200_Real
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
