using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_cars.Startup))]
namespace E_cars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
