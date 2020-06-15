using System.Web;
using System.Web.Mvc;

namespace UbiSoftApiScores
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
