using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClotingStore.Web.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var CategoriasBL = new CategoriaBL();
            var listadecategorias = categoriasBL.ObtenerCategorias();


            return View(listadecategorias);
        }
    }
}