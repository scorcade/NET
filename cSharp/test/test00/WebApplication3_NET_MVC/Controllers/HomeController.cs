using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3_NET_MVC.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult PageOne() {
            //ViewData
            base.ViewData["DataONe"] = "car";
            //ViewBag
            base.ViewBag.DataTwo= "plane";
            //Model
            Color c = new Color();
            c.colorone = "white";
            c.colortwo = "black";
            //TempData
            TempData["DataThree"] = "rockets";
            return View(c);

        }
    }

    public class Color
    {
        public string colorone;
        public string colortwo;


    }
}