using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantReviews.Startup))]
namespace RestaurantReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
