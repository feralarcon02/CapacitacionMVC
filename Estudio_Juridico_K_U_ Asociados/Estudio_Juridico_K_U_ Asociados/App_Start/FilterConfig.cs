using System.Web;
using System.Web.Mvc;

namespace Estudio_Juridico_K_U__Asociados
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
