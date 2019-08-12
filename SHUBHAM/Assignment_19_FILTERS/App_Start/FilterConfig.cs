using Assignment_19_FILTERS.CustomFilters;
using System.Web;
using System.Web.Mvc;

namespace Assignment_19_FILTERS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            
        }
    }
}
