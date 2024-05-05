using System.Web;
using System.Web.Mvc;

namespace Mvc_Codefirst_RazorSyntax
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
