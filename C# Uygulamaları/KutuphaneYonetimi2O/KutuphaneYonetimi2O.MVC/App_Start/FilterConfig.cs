using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi2O.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
