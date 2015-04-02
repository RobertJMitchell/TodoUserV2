using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoUserV2.Startup))]
namespace TodoUserV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
