using CajeroAutomatico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CajeroAutomatico.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        [HttpGet]
        public ActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index1(Cajero c)
        {
            if(c.monto % 5 == 0)
            {
                return Redirect("Correcto");
            }
            else
            {
                return Redirect("Error");
            }
            
        }

        [HttpGet]
        public ActionResult Correcto()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }
    }
}
