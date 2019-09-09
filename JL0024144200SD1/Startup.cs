using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JL0024144200SD1.Startup))]
namespace JL0024144200SD1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
