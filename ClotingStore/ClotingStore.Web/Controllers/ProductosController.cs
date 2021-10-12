
using ClotingStore.BL;
using System.Web.Mvc;

namespace ClotingStore.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();


            return View(listadeProductos);
        }
    }
}