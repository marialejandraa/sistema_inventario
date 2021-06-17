using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventarioEquipo.Web.Controllers
{
    public class EquipoController : Controller
    {
        // GET: Equipo
        public ActionResult Index()
        {
            var equipoBL = new EquiposBL();

            return View();
        }
    }
}