using System.Web;
using System.Web.Mvc;

namespace MVC_Codebased_test1_b
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
