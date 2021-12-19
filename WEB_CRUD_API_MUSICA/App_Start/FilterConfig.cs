using System.Web;
using System.Web.Mvc;

namespace WEB_CRUD_API_MUSICA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
