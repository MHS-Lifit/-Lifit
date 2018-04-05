using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lifit.Startup))]
namespace Lifit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
