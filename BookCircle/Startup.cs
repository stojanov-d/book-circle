using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookCircle.Startup))]
namespace BookCircle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
