using System.Web;
using System.Web.Mvc;

namespace _1811062547_TranLinhThuan_bigschoool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
