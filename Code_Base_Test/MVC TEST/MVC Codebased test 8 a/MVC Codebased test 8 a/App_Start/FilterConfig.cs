using System.Web;
using System.Web.Mvc;

namespace MVC_Codebased_test_8_a
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
