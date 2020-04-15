using System.Web;
using System.Web.Mvc;

namespace WebApiPoduct_seguro
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
