using System.Web;
using System.Web.Mvc;

namespace Milles_MIS4200_Real
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
