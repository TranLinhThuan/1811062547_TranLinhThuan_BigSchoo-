using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811062547_TranLinhThuan_bigschoool.Startup))]
namespace _1811062547_TranLinhThuan_bigschoool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
