using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using TiendaMVC.Filtros;
using TiendaMVC.Models;

namespace TiendaMVC.Controllers
{
    public class EtiquetaController : Controller
    {
        private Tienda10Entities db = new Tienda10Entities();
        // GET: Etiqueta

        [FiltroTiempo]
        public ActionResult Index()
        {
            var data = db.Etiqueta;
            ViewBag.Almacenes = db.Almacen;
            return View(data);

            var info = db.Almacen;
            ViewBag.alamcenes = info.ToList();
            ViewData["Titulo"] = "Listado de Almacenes";
            
        }
    }
}