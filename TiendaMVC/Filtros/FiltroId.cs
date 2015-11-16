using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TiendaMVC.Filtros
{
    public class FiltroId : ActionFilterAttribute
    {

        /*Es te filtro indica, que si no se le pasa un ID correcto, muestre una paguna en blanco (EmptyResult)
        Puede redirigirse a una pagina o mensaje de error, o incluso a otra web.
        Este filtro se aplicara a los metodos que creamos convenientes, si estuviera directamente en el controler
        se aplicaria a todos*/
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            String id = null;
            try
            {
                id = filterContext.ActionParameters["id"].ToString();
            }
            catch (Exception)
            {

            }
            var pet = filterContext.ActionDescriptor.ActionName;
            if (id == null && pet != "Index")
            {
                filterContext.Result = new EmptyResult();
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
