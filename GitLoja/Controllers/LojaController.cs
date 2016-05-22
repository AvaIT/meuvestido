using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitLoja.Controllers
{
    public class LojaController : Controller
    {
        // GET: Loja
        public ActionResult Index()
        {
            return View();
        }
    }
}