using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoSeriesGuru.Web.Models;

namespace ProjetoSeriesGuru.Web.Controllers
{
    public class SeriesController : Controller
    {
        //
        // GET: /Series/

        public ActionResult Index()
        {
            return View();
        }

    }
}
