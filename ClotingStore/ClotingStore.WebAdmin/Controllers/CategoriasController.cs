using ClotingStore.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClotingStore.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }
        // GET: Productos
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBL.ObtenerCategorias();

            return View(listadeCategorias);
        }

        public ActionResult Crear()
        {
            var nuevoCategoria = new Categorias();

            return View(nuevoCategoria);
        }
        [HttpPost]
        public ActionResult Crear(Categorias producto)
        {
            _categoriasBL.GuardarCategoria(producto);
            return RedirectToAction("Index");

        }

        public ActionResult Editar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);

            return View(producto);
        }
        [HttpPost]
        public ActionResult Editar(Categorias producto)
        {
            _categoriasBL.GuardarCategoria(producto);
            return RedirectToAction("Index");
        }
        public ActionResult Detalle(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);
        }
        [HttpPost]

        public ActionResult Eliminar(Categorias producto)
        {
            _categoriasBL.EliminarCategoria (producto.Id);
            return RedirectToAction("Index");
        }


    }

}