using System.Web;
using System.Web.Mvc;

namespace TEST_MVC_OPERATION_UI_003
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
