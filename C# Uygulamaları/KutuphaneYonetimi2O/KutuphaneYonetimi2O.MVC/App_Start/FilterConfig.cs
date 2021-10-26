using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
