using System.Web;
using System.Web.Mvc;

namespace PHAMANHAO_TEST2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
