using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMVC.Models;

namespace TiendaMVC.Controllers
{
    public class ProductoController : Controller
    {
        Tienda10Entities db = new Tienda10Entities();
        // GET: Producto
        public ActionResult Index()
        {
            var data = db.Producto;
            return View(data);
        }

        public ActionResult Detalle(String nombre)
        {
            var nom = nombre.Replace("_", " ");
            var data = db.Producto.FirstOrDefault(o => o.Nombre == nom);
            if (data == null)
                return RedirectToAction("Index");
            return View(data);

        }

        public ActionResult Alta()
        {
            return View(new Producto());
        }

        [HttpPost]
        public ActionResult Alta(Producto model)
        {
            if (ModelState.IsValid)
            {
                db.Producto.Add(model);
                db.SaveChanges();
                return View(new Producto());
            }

            return View(model); //Si los datos introducidos no son correctos, los vuelve a cargar en el formulario para que se modifiquen.
        }
   }
}