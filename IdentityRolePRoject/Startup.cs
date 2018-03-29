using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityRolePRoject.Startup))]
namespace IdentityRolePRoject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
