using System.Web;
using System.Web.Mvc;

namespace DataReader_3rd_ADO_Class
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
