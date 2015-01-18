using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myFLIP.Startup))]
namespace myFLIP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
