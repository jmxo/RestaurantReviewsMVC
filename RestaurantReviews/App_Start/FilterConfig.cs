using System.Web;
using System.Web.Mvc;

namespace RestaurantReviews
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // you can add your custom filter here
        }
    }
}
