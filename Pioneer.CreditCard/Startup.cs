using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pioneer.CreditCard.Startup))]
namespace Pioneer.CreditCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
