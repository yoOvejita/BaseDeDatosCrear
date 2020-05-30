using BaseDeDatosCrear.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseDeDatosCrear.Controllers
{
    public class HomeController : Controller
    {
        private EjemploASPNETEntities db = new EjemploASPNETEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EjemploCreacion() {//La vista general donde se muestra la lista de productos
            ViewBag.productos = db.Producto.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Agregar()//La vista para agregar un nuevo registro (formulario)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(Producto prod) {
            db.Producto.Add(prod);//Acá agrega el nuevo objeto al conjunto de datos recibidos de la DDBB
            db.SaveChanges();//Acá actualiza la base de datos.
            return RedirectToAction("EjemploCreacion");
        }
    }
}