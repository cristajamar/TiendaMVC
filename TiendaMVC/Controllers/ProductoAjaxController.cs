using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMVC.Models;

namespace TiendaMVC.Controllers
{
    public class ProductoAjaxController : Controller
    {
        Tienda10Entities db = new Tienda10Entities();
        // GET: ProductoAjax
        public ActionResult Index()
        {
            return View(db.Producto);
        }


        //Para deshabilitar la cache
        [OutputCache(Duration = 0, VaryByParam = "*")]
        public ActionResult Buscar(String nombre)
        {
            var data = db.Producto.Where(o => o.Nombre.Contains(nombre));
            return PartialView("_listadoProducto", data);
        }

        [HttpPost]

        public ActionResult Alta(Producto model)
        {
            db.Producto.Add(model);
            db.SaveChanges();
            ModelState.Clear();
            return Json(model);
        }
    }
}