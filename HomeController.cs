using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;
using Razor.Controllers;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Insurance newInsurance = new Insurance
        {
            InsuranceID = 1,
            Client = "Oleg Luchitskiy",
            Type = "Medical",
            Sum =  100000 
        };
        public ActionResult Index()
        {
            return View(newInsurance);
        }
        public ActionResult ClientAndType() { 
            return View(newInsurance); 
        }
        public ActionResult DemoExpression()
        {
            ViewBag.InsuranceCount = 4; 
            return View(newInsurance);
        }
        public ActionResult DemoArray() {
            Insurance[] array = {
                new Insurance { Client = "Pablo Picasso", Sum = 50000 }, 
                new Insurance { Client = "Leonardo da Vinci", Sum = 20000 }, 
                new Insurance { Client = "Leonardo di Caprio", Sum = 75000 },
                new Insurance { Client = "Albert Einstein", Sum = 120000 } }; 
            return View(array); 
        }
    }
}