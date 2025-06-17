using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrystalFramework.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ozellikler()
        {
            return View();
        }
        public ActionResult Destek()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Singleblog()
        {
            return View();
        }
    }
}