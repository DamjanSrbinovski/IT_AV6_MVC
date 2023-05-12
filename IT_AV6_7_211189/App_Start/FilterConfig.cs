using System.Web;
using System.Web.Mvc;

namespace IT_AV6_7_211189
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
