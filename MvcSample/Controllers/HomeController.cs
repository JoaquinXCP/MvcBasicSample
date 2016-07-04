using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSample.Models;
namespace MvcSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {

            User prueba = new User() { Username = "Jaimito", Age = 15 };

            return View(prueba);

        }



    }
}
