using System.Web;
using System.Web.Mvc;

namespace Image_Uploding_Without_Db_Connection
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
