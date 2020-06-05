using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoDuyThuan_Lab456.Startup))]
namespace HoDuyThuan_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
